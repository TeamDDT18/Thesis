/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace ThesisServer
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public const uint Plant1 = 50;

        /// <summary>
        /// The identifier for the Plant1_Tank1 Object.
        /// </summary>
        public const uint Plant1_Tank1 = 51;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice = 68;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_LevelMeter = 69;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_InputPipe Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_InputPipe = 75;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_InputPipe_FillValve Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_InputPipe_FillValve = 76;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe = 78;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve = 79;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter = 81;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton = 83;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StartButton = 84;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StopButton = 86;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_ResetButton = 88;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton Object.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_modeButton = 90;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController Object.
        /// </summary>
        public const uint Plant1_Tank1_LevelController = 97;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public const uint GenericControllerType = 92;

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public const uint AnalogInputType = 1;

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public const uint AnalogOutputType = 7;

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public const uint DigitalType = 32;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 9;

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public const uint AnalogSensorType = 102;

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public const uint ButtonType = 66;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public const uint GenericControllerType_SetPoint = 93;

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public const uint GenericControllerType_Ki = 94;

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public const uint GenericControllerType_Kp = 95;

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public const uint GenericControllerType_Kd = 96;

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public const uint AnalogInputType_Output = 2;

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimt Variable.
        /// </summary>
        public const uint AnalogInputType_HighLimt = 3;

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimit Variable.
        /// </summary>
        public const uint AnalogInputType_LowLimit = 4;

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimtAlarm Variable.
        /// </summary>
        public const uint AnalogInputType_HighLimtAlarm = 5;

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimitAlarm Variable.
        /// </summary>
        public const uint AnalogInputType_LowLimitAlarm = 6;

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public const uint AnalogOutputType_Input = 8;

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public const uint DigitalType_Value = 33;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_Output Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_LevelMeter_Output = 70;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_HighLimt Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_LevelMeter_HighLimt = 71;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_LowLimit Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_LevelMeter_LowLimit = 72;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_HighLimtAlarm Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_LevelMeter_HighLimtAlarm = 73;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_LowLimitAlarm Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_LevelMeter_LowLimitAlarm = 74;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_InputPipe_FillValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_InputPipe_FillValve_Input = 77;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve_Input Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve_Input = 80;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_Output Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_Output = 108;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimt Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimt = 109;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimit Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimit = 110;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimtAlarm Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimtAlarm = 111;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimitAlarm Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimitAlarm = 112;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StartButton_Value = 85;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_StopButton_Value = 87;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_ResetButton_Value = 89;

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton_Value Variable.
        /// </summary>
        public const uint Plant1_Tank1_OperationButton_modeButton_Value = 91;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_SetPoint Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_SetPoint = 98;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Ki Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_Ki = 99;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kp Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_Kp = 100;

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kd Variable.
        /// </summary>
        public const uint Plant1_Tank1_LevelController_Kd = 101;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Plant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1 = new ExpandedNodeId(ThesisServer.Objects.Plant1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1 = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_LevelMeter = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice_LevelMeter, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_InputPipe Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_InputPipe = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice_InputPipe, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_InputPipe_FillValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_InputPipe_FillValve = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice_InputPipe_FillValve, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice_OutputPipe, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StartButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationButton_StartButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StopButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationButton_StopButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_ResetButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationButton_ResetButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_modeButton = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_OperationButton_modeButton, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController Object.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController = new ExpandedNodeId(ThesisServer.Objects.Plant1_Tank1_LevelController, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType = new ExpandedNodeId(ThesisServer.ObjectTypes.GenericControllerType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogInputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogOutputType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType = new ExpandedNodeId(ThesisServer.ObjectTypes.DigitalType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(ThesisServer.ObjectTypes.ValveType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogSensorType = new ExpandedNodeId(ThesisServer.ObjectTypes.AnalogSensorType, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the ButtonType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ButtonType = new ExpandedNodeId(ThesisServer.ObjectTypes.ButtonType, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericControllerType_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_SetPoint = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Ki = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kp = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the GenericControllerType_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericControllerType_Kd = new ExpandedNodeId(ThesisServer.Variables.GenericControllerType_Kd, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_Output = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimt Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_HighLimt = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_HighLimt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimit Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_LowLimit = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_LowLimit, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_HighLimtAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_HighLimtAlarm = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_HighLimtAlarm, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogInputType_LowLimitAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogInputType_LowLimitAlarm = new ExpandedNodeId(ThesisServer.Variables.AnalogInputType_LowLimitAlarm, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the AnalogOutputType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogOutputType_Input = new ExpandedNodeId(ThesisServer.Variables.AnalogOutputType_Input, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the DigitalType_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId DigitalType_Value = new ExpandedNodeId(ThesisServer.Variables.DigitalType_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_LevelMeter_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_LevelMeter_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_HighLimt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_LevelMeter_HighLimt = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_LevelMeter_HighLimt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_LowLimit Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_LevelMeter_LowLimit = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_LevelMeter_LowLimit, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_HighLimtAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_LevelMeter_HighLimtAlarm = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_LevelMeter_HighLimtAlarm, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_LevelMeter_LowLimitAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_LevelMeter_LowLimitAlarm = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_LevelMeter_LowLimitAlarm, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_InputPipe_FillValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_InputPipe_FillValve_Input = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_InputPipe_FillValve_Input, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve_Input = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_OutputPipe_DischargeValve_Input, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_Output = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_Output, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimt Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimt = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimt, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimit Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimit = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimit, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimtAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimtAlarm = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_HighLimtAlarm, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimitAlarm Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimitAlarm = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationDevice_OutputPipe_FlowMeter_LowLimitAlarm, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StartButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StartButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationButton_StartButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_StopButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_StopButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationButton_StopButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_ResetButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_ResetButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationButton_ResetButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_OperationButton_modeButton_Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_OperationButton_modeButton_Value = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_OperationButton_modeButton_Value, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_SetPoint Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_SetPoint = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_LevelController_SetPoint, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Ki Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_Ki = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_LevelController_Ki, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_Kp = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_LevelController_Kp, ThesisServer.Namespaces.ThesisServer);

        /// <summary>
        /// The identifier for the Plant1_Tank1_LevelController_Kd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Plant1_Tank1_LevelController_Kd = new ExpandedNodeId(ThesisServer.Variables.Plant1_Tank1_LevelController_Kd, ThesisServer.Namespaces.ThesisServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AnalogInputType component.
        /// </summary>
        public const string AnalogInputType = "AnalogInputType";

        /// <summary>
        /// The BrowseName for the AnalogOutputType component.
        /// </summary>
        public const string AnalogOutputType = "AnalogOutputType";

        /// <summary>
        /// The BrowseName for the AnalogSensorType component.
        /// </summary>
        public const string AnalogSensorType = "AnalogSensorType";

        /// <summary>
        /// The BrowseName for the ButtonType component.
        /// </summary>
        public const string ButtonType = "ButtonType";

        /// <summary>
        /// The BrowseName for the DigitalType component.
        /// </summary>
        public const string DigitalType = "DigitalType";

        /// <summary>
        /// The BrowseName for the GenericControllerType component.
        /// </summary>
        public const string GenericControllerType = "GenericControllerType";

        /// <summary>
        /// The BrowseName for the HighLimt component.
        /// </summary>
        public const string HighLimt = "HighLimt";

        /// <summary>
        /// The BrowseName for the HighLimtAlarm component.
        /// </summary>
        public const string HighLimtAlarm = "HighLimtAlarm";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the Kd component.
        /// </summary>
        public const string Kd = "Kd";

        /// <summary>
        /// The BrowseName for the Ki component.
        /// </summary>
        public const string Ki = "Ki";

        /// <summary>
        /// The BrowseName for the Kp component.
        /// </summary>
        public const string Kp = "Kp";

        /// <summary>
        /// The BrowseName for the LowLimit component.
        /// </summary>
        public const string LowLimit = "LowLimit";

        /// <summary>
        /// The BrowseName for the LowLimitAlarm component.
        /// </summary>
        public const string LowLimitAlarm = "LowLimitAlarm";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the Plant1 component.
        /// </summary>
        public const string Plant1 = "Plant 1";

        /// <summary>
        /// The BrowseName for the SetPoint component.
        /// </summary>
        public const string SetPoint = "SetPoint";

        /// <summary>
        /// The BrowseName for the Tank1 component.
        /// </summary>
        public const string Tank1 = "Tank 1";

        /// <summary>
        /// The BrowseName for the Value component.
        /// </summary>
        public const string Value = "Value";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the ThesisServer namespace (.NET code namespace is 'ThesisServer').
        /// </summary>
        public const string ThesisServer = "http://opcfoundation.org/ThesisServer";
    }
    #endregion
}