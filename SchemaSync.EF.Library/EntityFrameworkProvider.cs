using SchemaSync.Library.Interfaces;
using SchemaSync.Library.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace SchemaSync.EF.Library
{
	public class EntityFrameworkProvider : IDbAssemblyProvider
	{
		public ObjectTypeFlags ObjectTypes => ObjectTypeFlags.Tables | ObjectTypeFlags.ForeignKeys | ObjectTypeFlags.Schemas;

		public Database GetDatabase(string path)
		{
			var assembly = Assembly.LoadFrom(path);
			return GetDatabase(assembly);
		}

		public Database GetDatabase(Assembly assembly)
		{
			var types = assembly.GetExportedTypes();
			var typeTableMap = GetTypeTableDictionary(types);

			throw new NotImplementedException();
		}

		private Dictionary<Type, Table> GetTypeTableDictionary(Type[] types)
		{
			throw new NotImplementedException();
		}
	}
}