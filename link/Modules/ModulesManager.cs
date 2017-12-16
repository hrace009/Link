using System;
using System.Collections.Generic;
using Link.Net;
using System.Reflection;

namespace Link.Modules
{

    public class ModulesManager
    {
        private static Type[] emptyTypes = { };
        private static object[] emptyArgs = { };
        private static Type moduleType = typeof(ModuleBase);

        public Session Session { get; private set; }

        public Dictionary<Type, ModuleBase> Modules { get; private set; }

        public ModulesManager(Session session)
        {
            Session = session;
            Modules = new Dictionary<Type, ModuleBase>();
        }


        public int Count
        {
            get
            {
                return Modules.Count;
            }
        }

        public static bool IsModule(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException();
            }
            return type.GetTypeInfo().IsSubclassOf(moduleType);
        }
        private static void ValidateType(Type type)
        {
            if (!IsModule(type))
            {
                throw new ArgumentException();
            }
        }

        public T Register<T>() where T : ModuleBase
        {
            return Register(typeof(T)) as T;
        }
        public ModuleBase Register(Type type)
        {
            ValidateType(type);

            ModuleBase module;
            if (!TryGetModule(type, out module))
            {
                module = type.GetConstructor(emptyTypes).Invoke(emptyArgs) as ModuleBase;
                Modules[type] = module;

                module.Session = Session;
                module.Proto = Session.Proto;
                module.Enabled = true;
                module.Initialize();
            }
            return module;
        }

        public T GetModule<T>() where T : ModuleBase
        {
            return GetModule(typeof(T)) as T;
        }
        public ModuleBase GetModule(Type type)
        {
            ValidateType(type);

            return Modules[type];
        }

        public bool TryGetModule<T>(out T module) where T : ModuleBase
        {
            ModuleBase res;
            if (TryGetModule(typeof(T), out res))
            {
                module = res as T;
                return true;
            }
            else
            {
                module = default(T);
                return false;
            }
        }
        public bool TryGetModule(Type type, out ModuleBase module)
        {
            ValidateType(type);

            return Modules.TryGetValue(type, out module);
        }

        public bool Contains<T>() where T : ModuleBase
        {
            return Contains(typeof(T));
        }
        public bool Contains(Type type)
        {
            ValidateType(type);
            return Modules.ContainsKey(type);
        }

        public ModuleBase[] ToArray()
        {
            var res = new ModuleBase[Modules.Count];
            var i = 0;
            foreach (var module in Modules.Values)
            {
                res[i++] = module;
            }
            return res;
        }
    }
}

