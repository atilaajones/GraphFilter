﻿using GraphX;
using GraphX.Common.Models;

namespace GraphFilter.GraphX_Utils
{
    public class DataVertex: VertexBase
    {
        /// <summary>
        /// Some string property for example purposes
        /// </summary>
        public string Text { get; set; }

        #region Calculated or static props

        public override string ToString()
        {
            return Text;
        }


        #endregion

        /// <summary>
        /// Default parameterless constructor for this class
        /// (required for YAXLib serialization)
        /// </summary>
        public DataVertex() : this("")
        {
        }

        public DataVertex(string text = "")
        {
            Text = text;
        }
    }
}