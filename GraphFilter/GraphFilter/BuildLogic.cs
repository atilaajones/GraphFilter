﻿using Flee.PublicTypes;
using GraphFilter.Invariants;
using System;
using System.Linq;

namespace GraphFilter
{
    public static class BuildLogic
    {
        #region Invariants boolean
        public static bool ConditionRegular(Graph g)
        {
            return InvariantBool.IsRegular.Calculate(g);
        }
        public static bool ConditionRegularK(Graph g, int k)
        {
            return InvariantBool.IsRegularWithDegree.Calculate(g, k);
        }
        public static bool ConditionConnected(Graph g)
        {
            bool x = InvariantBool.IsConnected.Calculate(g);
            return InvariantBool.IsConnected.Calculate(g);
        }
        public static bool ConditionPlanar(Graph g)
        {
            return InvariantBool.IsPlanar.Calculate(g);
        }

        public static bool ConditionHamiltonian(Graph g)
        {
            return InvariantBool.IsHamiltonian.Calculate(g);
        }

        public static bool ConditionAcyclic(Graph g)
        {
            return InvariantBool.IsAcyclic.Calculate(g);
        }
        #endregion

        #region Equation and Conditon
        public static bool EvaluateText(string text, Graph g)
        {
        if (!text.Any()) return true;
            //Alterei de text.count() == 0 para text.any()
         ExpressionContext context = new ExpressionContext();
            VariableCollection variables = context.Variables;

        foreach (IInvariant invariant in InvariantNum.List())
        {
                if (text.Contains(invariant.getCode() + "_G")) context.Variables[invariant.getCode() + "_G"] = invariant.Calculate(g);
                if (text.Contains(invariant.getCode() + "_lG")) context.Variables[invariant.getCode() + "_lG"] = invariant.Calculate(Operation.Line(g));
                if (text.Contains(invariant.getCode() + "_cG")) context.Variables[invariant.getCode() + "_cG"] = invariant.Calculate(Operation.Complement(g));
            }
            IGenericExpression<bool> e = context.CompileGeneric<bool>(text);
            return e.Evaluate();
            
            
            //throw new ExpressionCompileException();
        }

        public static bool ValidadeEquation(string text)
        {
            if (!text.Any()) return true;
            //alterei para text.any() também
            ExpressionContext context = new ExpressionContext();
            VariableCollection variables = context.Variables;

            foreach (IInvariant invariant in InvariantNum.List())
            {
                if (text.Contains(invariant.getCode() + "_G")) context.Variables[invariant.getCode() + "_G"] = invariant.Calculate(new Graph(new int[0,0]));
                if (text.Contains(invariant.getCode() + "_lG")) context.Variables[invariant.getCode() + "_lG"] = invariant.Calculate(new Graph(new int[0, 0]));
                if (text.Contains(invariant.getCode() + "_cG")) context.Variables[invariant.getCode() + "_cG"] = invariant.Calculate(new Graph(new int[0, 0]));
            }
            IGenericExpression<bool> e = context.CompileGeneric<bool>(text);
            return e.Evaluate();
        }


        #endregion
    }
}

