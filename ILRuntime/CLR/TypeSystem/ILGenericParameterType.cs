﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ILRuntime.CLR.TypeSystem
{
    class ILGenericParameterType : IType
    {
        string name;
        public ILGenericParameterType(string name)
        {
            this.name = name;
        }
        public bool IsGenericInstance
        {
            get { return false; }
        }

        public KeyValuePair<string, IType>[] GenericArguments
        {
            get { return null; }
        }

        public Type TypeForCLR
        {
            get { return typeof(ILGenericParameterType); }
        }

        public string FullName
        {
            get { return name; }
        }

        public Runtime.Enviorment.AppDomain AppDomain
        {
            get { return null; }
        }

        public Method.IMethod GetMethod(string name, int paramCount)
        {
            return null;
        }

        public Method.IMethod GetMethod(string name, List<IType> param, IType[] genericArguments)
        {
            return null;
        }

        public List<Method.IMethod> GetMethods()
        {
            return null;
        }

        public Method.IMethod GetConstructor(List<IType> param)
        {
            return null;
        }

        public bool CanAssignTo(IType type)
        {
            return false;
        }

        public IType MakeGenericInstance(KeyValuePair<string, IType>[] genericArguments)
        {
            return null;
        }

        public IType ResolveGenericType(IType contextType)
        {
            throw new NotImplementedException();
        }
    }
}