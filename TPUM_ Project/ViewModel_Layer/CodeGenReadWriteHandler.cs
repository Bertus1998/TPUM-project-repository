//UMX Code Generated
/*
NOTE: THIS FILE CONTAINS AUTO GENERATED SOURCE CODE.
      ANY MANUAL CHANGES TO THIS FILE WILL BE OVERWRITTEN IF THE CODE GENERATOR IS RE-EXECUTED.
*/

using System;
using System.Collections.Generic;
using Opc.Ua;

namespace CodeGenerated
{
    public class CodeGenReadWriteHandler
    {
        private CodeGenReadWriteHandler()
        {

        }

        public static CodeGenReadWriteHandler GetInstance()
        {
            if (m_CodeGenReadWriteHandler == null)
                m_CodeGenReadWriteHandler = new CodeGenReadWriteHandler();

            return m_CodeGenReadWriteHandler;
        }
        public ServiceResult OnRead(
         ISystemContext context,
         NodeState node,
         NumericRange indexRange,
         QualifiedName dataEncoding,
         ref object value,
         ref StatusCode statusCode,
         ref DateTime timestamp)
        {
            // Sample code to populate variable value.             
			//TODO: User code here...
			//      This is where to link to the underlying system actual values.
            Random rnd = new Random();
            value = rnd.Next(1, 10000);
            
            return ServiceResult.Good;
        }

        public ServiceResult OnWrite(
           ISystemContext context,
           NodeState node,
           NumericRange indexRange,
           QualifiedName dataEncoding,
           ref object value,
           ref StatusCode statusCode,
           ref DateTime timestamp)
        {
            BaseDataVariableState variable = node as BaseDataVariableState;

            // verify data type.
            Opc.Ua.TypeInfo typeInfo = Opc.Ua.TypeInfo.IsInstanceOfDataType(
                value,
                variable.DataType,
                variable.ValueRank,
                context.NamespaceUris,
                context.TypeTable);

            if (typeInfo == null || typeInfo == Opc.Ua.TypeInfo.Unknown)
            {
                return StatusCodes.BadTypeMismatch;
            }

            // check index range.
            if (variable.ValueRank >= 0)
            {
                if (indexRange != NumericRange.Empty)
                {
                    object target = variable.Value;
                    ServiceResult result = indexRange.UpdateRange(ref target, value);

                    if (ServiceResult.IsBad(result))
                    {
                        return result;
                    }

                    value = target;
                }
            }

            return ServiceResult.Good;
        }

        private static CodeGenReadWriteHandler m_CodeGenReadWriteHandler;
    }
}
