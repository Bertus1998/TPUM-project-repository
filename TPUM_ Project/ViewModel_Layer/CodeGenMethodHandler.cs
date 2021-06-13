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
    public class CodeGenMethodHandler
    {
        private CodeGenMethodHandler()
        {

        }

        public static CodeGenMethodHandler GetInstance()
        {
            if (m_codeGenMethodHandler == null)
                m_codeGenMethodHandler = new CodeGenMethodHandler();

            return m_codeGenMethodHandler;
        }

        public ServiceResult OnAddCall(
           ISystemContext context,
           MethodState method,
           IList<object> inputArguments,
           IList<object> outputArguments)
        {
            /*
            // all arguments must be provided.
            if (inputArguments.Count < 2)
            {
                return StatusCodes.BadArgumentsMissing;
            }

            try
            {
                UInt32 num1 = (UInt32)inputArguments[0];
                UInt32 num2 = (UInt32)inputArguments[1];

                // set output parameter
                outputArguments[0] = num1 + num2;
                return ServiceResult.Good;
            }
            catch
            {
                return new ServiceResult(StatusCodes.BadInvalidArgument);
            }
            */

            return ServiceResult.Good;
        }

        private static CodeGenMethodHandler m_codeGenMethodHandler;
    }
}
