using System;
using System.Linq;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.ShaderGraph.Drawing.Colors
{
    class PrecisionColors : ColorProviderFromStyleSheet
    {
        public override string GetTitle() => "Precision";

        public override bool AllowCustom() => false;

        public override bool ClearOnDirty() => true;

        protected override bool GetClassFromNode(AbstractMaterialNode node, out string ussClass)
        {
            var graphPrecision = node.graphPrecision;
            if (graphPrecision == GraphPrecision.Graph)
            {
                // fall back to whatever the graph uses as its default precision
                ussClass = node.owner.graphDefaultPrecision.ToString();
            }
            else
            {
                // node chose something -- use that
                ussClass = graphPrecision.ToString();
            }

            return !string.IsNullOrEmpty(ussClass);
        }

        public override void ClearColor(IShaderNodeView nodeView)
        {
            foreach (var type in GraphPrecision.GetValues(typeof(GraphPrecision)))
            {
                nodeView.colorElement.RemoveFromClassList(type.ToString());
            }
        }
    }

    class GraphPrecisionColors : ColorProviderFromStyleSheet
    {
        public override string GetTitle() => "Graph Precision";

        public override bool AllowCustom() => false;

        public override bool ClearOnDirty() => true;

        protected override bool GetClassFromNode(AbstractMaterialNode node, out string ussClass)
        {
            ussClass = node.graphPrecision.ToString();

            return !string.IsNullOrEmpty(ussClass);
        }

        public override void ClearColor(IShaderNodeView nodeView)
        {
            foreach (var type in GraphPrecision.GetValues(typeof(GraphPrecision)))
            {
                nodeView.colorElement.RemoveFromClassList(type.ToString());
            }
        }
    }
}
