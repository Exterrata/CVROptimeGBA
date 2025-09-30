//  -------------------------- WasmBinder -------------------------
// !!! THIS FILE WAS AUTO-GENERATED, MANUAL CHANGES WILL BE LOST !!!
//  ---------------------------------------------------------------

#pragma warning disable IL2072 // RuntimeHelpers.GetUninitializedObject complains about WasmScripting.TypeMap.GetType
#pragma warning disable IL2087 // RuntimeHelpers.GetUninitializedObject complains about typeof()

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WasmScripting;

namespace UnityEngine
{

    public partial class Debug(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public Debug()
            : this(internal_UnityEngineDebug__ctor()) { }

        public static bool developerConsoleVisible 
        {
            get => internal_UnityEngineDebug__get__developerConsoleVisible();
            set => internal_UnityEngineDebug__set__developerConsoleVisible(value);
        }

        public static bool isDebugBuild 
        {
            get => internal_UnityEngineDebug__get__isDebugBuild();
        }

        public static void DrawLine(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Color color, float duration)
        {
            internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(start, end, color, duration);
        }

        public static void DrawLine(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Color color)
        {
            internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(start, end, color);
        }

        public static void DrawLine(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end)
        {
            internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__SystemVoid(start, end);
        }

        public static void DrawLine(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Color color, float duration, bool depthTest)
        {
            internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(start, end, color, duration, depthTest);
        }

        public static void DrawRay(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, global::UnityEngine.Color color, float duration)
        {
            internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(start, dir, color, duration);
        }

        public static void DrawRay(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, global::UnityEngine.Color color)
        {
            internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(start, dir, color);
        }

        public static void DrawRay(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir)
        {
            internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__SystemVoid(start, dir);
        }

        public static void DrawRay(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, global::UnityEngine.Color color, float duration, bool depthTest)
        {
            internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(start, dir, color, duration, depthTest);
        }

        public static void Break()
        {
            internal_UnityEngineDebug__func__Break__SystemVoid();
        }

        public static void DebugBreak()
        {
            internal_UnityEngineDebug__func__DebugBreak__SystemVoid();
        }

        public static void Log(object message, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__Log__SystemObject__UnityEngineObject__SystemVoid(message, context);
        }

        public static void LogFormat(string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogFormat__SystemString__SystemObjectArray__SystemVoid(format, args);
        }

        public static void LogFormat(global::UnityEngine.Object context, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context, format, args);
        }

        public static void LogFormat(global::UnityEngine.LogType logType, global::UnityEngine.LogOption logOptions, global::UnityEngine.Object context, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogFormat__UnityEngineLogTypeEnum__UnityEngineLogOptionEnum__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(logType, logOptions, context, format, args);
        }

        public static void LogError(object message, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__LogError__SystemObject__UnityEngineObject__SystemVoid(message, context);
        }

        public static void LogErrorFormat(string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogErrorFormat__SystemString__SystemObjectArray__SystemVoid(format, args);
        }

        public static void LogErrorFormat(global::UnityEngine.Object context, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogErrorFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context, format, args);
        }

        public static void ClearDeveloperConsole()
        {
            internal_UnityEngineDebug__func__ClearDeveloperConsole__SystemVoid();
        }

        public static void LogException(global::System.Exception exception)
        {
            internal_UnityEngineDebug__func__LogException__SystemException__SystemVoid(exception);
        }

        public static void LogException(global::System.Exception exception, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__LogException__SystemException__UnityEngineObject__SystemVoid(exception, context);
        }

        public static void LogWarning(object message, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__LogWarning__SystemObject__UnityEngineObject__SystemVoid(message, context);
        }

        public static void LogWarningFormat(string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogWarningFormat__SystemString__SystemObjectArray__SystemVoid(format, args);
        }

        public static void LogWarningFormat(global::UnityEngine.Object context, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogWarningFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context, format, args);
        }

        public static void Assert(bool condition)
        {
            internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemVoid(condition);
        }

        public static void Assert(bool condition, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__Assert__SystemBoolean__UnityEngineObject__SystemVoid(condition, context);
        }

        public static void Assert(bool condition, object message)
        {
            internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__SystemVoid(condition, message);
        }

        public static void Assert(bool condition, string message)
        {
            internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemString__SystemVoid(condition, message);
        }

        public static void Assert(bool condition, object message, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__UnityEngineObject__SystemVoid(condition, message, context);
        }

        public static void Assert(bool condition, string message, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemString__UnityEngineObject__SystemVoid(condition, message, context);
        }

        public static void AssertFormat(bool condition, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__AssertFormat__SystemBoolean__SystemString__SystemObjectArray__SystemVoid(condition, format, args);
        }

        public static void AssertFormat(bool condition, global::UnityEngine.Object context, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__AssertFormat__SystemBoolean__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(condition, context, format, args);
        }

        public static void LogAssertion(object message)
        {
            internal_UnityEngineDebug__func__LogAssertion__SystemObject__SystemVoid(message);
        }

        public static void LogAssertion(object message, global::UnityEngine.Object context)
        {
            internal_UnityEngineDebug__func__LogAssertion__SystemObject__UnityEngineObject__SystemVoid(message, context);
        }

        public static void LogAssertionFormat(string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogAssertionFormat__SystemString__SystemObjectArray__SystemVoid(format, args);
        }

        public static void LogAssertionFormat(global::UnityEngine.Object context, string format, params global::System.Object[] args)
        {
            internal_UnityEngineDebug__func__LogAssertionFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context, format, args);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineDebug__ctor()
        {
            return UnityEngineDebug__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineDebug__get__developerConsoleVisible()
        {
            var methodCallResult = UnityEngineDebug__get__developerConsoleVisible();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__set__developerConsoleVisible(bool developerConsoleVisible)
        {
            var developerConsoleVisibleConverted = Unsafe.As<bool, int>(ref developerConsoleVisible);
            UnityEngineDebug__set__developerConsoleVisible(developerConsoleVisibleConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe bool internal_UnityEngineDebug__get__isDebugBuild()
        {
            var methodCallResult = UnityEngineDebug__get__isDebugBuild();
            var returnResult = Unsafe.As<int, bool>(ref methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Color color, float duration)
        {
            UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), Unsafe.AsPointer(ref color), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Color color)
        {
            UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end)
        {
            UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, global::UnityEngine.Color color, float duration, bool depthTest)
        {
            var depthTestConverted = Unsafe.As<bool, int>(ref depthTest);
            UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref end), Unsafe.AsPointer(ref color), duration, depthTestConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, global::UnityEngine.Color color, float duration)
        {
            UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref dir), Unsafe.AsPointer(ref color), duration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, global::UnityEngine.Color color)
        {
            UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref dir), Unsafe.AsPointer(ref color));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir)
        {
            UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref dir));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 dir, global::UnityEngine.Color color, float duration, bool depthTest)
        {
            var depthTestConverted = Unsafe.As<bool, int>(ref depthTest);
            UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(Unsafe.AsPointer(ref start), Unsafe.AsPointer(ref dir), Unsafe.AsPointer(ref color), duration, depthTestConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Break__SystemVoid()
        {
            UnityEngineDebug__func__Break__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__DebugBreak__SystemVoid()
        {
            UnityEngineDebug__func__DebugBreak__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Log__SystemObject__UnityEngineObject__SystemVoid(object message, global::UnityEngine.Object context)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__Log__SystemObject__UnityEngineObject__SystemVoid((message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogFormat__SystemString__SystemObjectArray__SystemVoid(string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogFormat__SystemString__SystemObjectArray__SystemVoid(formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(global::UnityEngine.Object context, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context.WrappedId, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogFormat__UnityEngineLogTypeEnum__UnityEngineLogOptionEnum__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(global::UnityEngine.LogType logType, global::UnityEngine.LogOption logOptions, global::UnityEngine.Object context, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogFormat__UnityEngineLogTypeEnum__UnityEngineLogOptionEnum__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid((int) logType, (int) logOptions, context.WrappedId, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogError__SystemObject__UnityEngineObject__SystemVoid(object message, global::UnityEngine.Object context)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__LogError__SystemObject__UnityEngineObject__SystemVoid((message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogErrorFormat__SystemString__SystemObjectArray__SystemVoid(string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogErrorFormat__SystemString__SystemObjectArray__SystemVoid(formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogErrorFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(global::UnityEngine.Object context, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogErrorFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context.WrappedId, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__ClearDeveloperConsole__SystemVoid()
        {
            UnityEngineDebug__func__ClearDeveloperConsole__SystemVoid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogException__SystemException__SystemVoid(global::System.Exception exception)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Exception is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__LogException__SystemException__SystemVoid(0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogException__SystemException__UnityEngineObject__SystemVoid(global::System.Exception exception, global::UnityEngine.Object context)
        {
            // Todo: throw new global::System.NotImplementedException("The type global::System.Exception is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__LogException__SystemException__UnityEngineObject__SystemVoid(0 /* Todo: Fix this */, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogWarning__SystemObject__UnityEngineObject__SystemVoid(object message, global::UnityEngine.Object context)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__LogWarning__SystemObject__UnityEngineObject__SystemVoid((message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogWarningFormat__SystemString__SystemObjectArray__SystemVoid(string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogWarningFormat__SystemString__SystemObjectArray__SystemVoid(formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogWarningFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(global::UnityEngine.Object context, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogWarningFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context.WrappedId, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemVoid(bool condition)
        {
            var conditionConverted = Unsafe.As<bool, int>(ref condition);
            UnityEngineDebug__func__Assert__SystemBoolean__SystemVoid(conditionConverted);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Assert__SystemBoolean__UnityEngineObject__SystemVoid(bool condition, global::UnityEngine.Object context)
        {
            var conditionConverted = Unsafe.As<bool, int>(ref condition);
            UnityEngineDebug__func__Assert__SystemBoolean__UnityEngineObject__SystemVoid(conditionConverted, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__SystemVoid(bool condition, object message)
        {
            var conditionConverted = Unsafe.As<bool, int>(ref condition);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__SystemVoid(conditionConverted, (message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemString__SystemVoid(bool condition, string message)
        {
            fixed (char* messagePointer = message)
            {
                var conditionConverted = Unsafe.As<bool, int>(ref condition);
                UnityEngineDebug__func__Assert__SystemBoolean__SystemString__SystemVoid(conditionConverted, messagePointer, message.Length * sizeof(char));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__UnityEngineObject__SystemVoid(bool condition, object message, global::UnityEngine.Object context)
        {
            var conditionConverted = Unsafe.As<bool, int>(ref condition);
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__UnityEngineObject__SystemVoid(conditionConverted, (message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__Assert__SystemBoolean__SystemString__UnityEngineObject__SystemVoid(bool condition, string message, global::UnityEngine.Object context)
        {
            fixed (char* messagePointer = message)
            {
                var conditionConverted = Unsafe.As<bool, int>(ref condition);
                UnityEngineDebug__func__Assert__SystemBoolean__SystemString__UnityEngineObject__SystemVoid(conditionConverted, messagePointer, message.Length * sizeof(char), context.WrappedId);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__AssertFormat__SystemBoolean__SystemString__SystemObjectArray__SystemVoid(bool condition, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    var conditionConverted = Unsafe.As<bool, int>(ref condition);
                    UnityEngineDebug__func__AssertFormat__SystemBoolean__SystemString__SystemObjectArray__SystemVoid(conditionConverted, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__AssertFormat__SystemBoolean__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(bool condition, global::UnityEngine.Object context, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    var conditionConverted = Unsafe.As<bool, int>(ref condition);
                    UnityEngineDebug__func__AssertFormat__SystemBoolean__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(conditionConverted, context.WrappedId, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogAssertion__SystemObject__SystemVoid(object message)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__LogAssertion__SystemObject__SystemVoid((message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogAssertion__SystemObject__UnityEngineObject__SystemVoid(object message, global::UnityEngine.Object context)
        {
            // Todo: throw new global::System.NotImplementedException("The type object is not implemented yet! We need to find a way to pass non-wrapped instances...");
            UnityEngineDebug__func__LogAssertion__SystemObject__UnityEngineObject__SystemVoid((message as IProxyObject)?.WrappedId ?? 0 /* Todo: Fix this */, context.WrappedId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogAssertionFormat__SystemString__SystemObjectArray__SystemVoid(string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogAssertionFormat__SystemString__SystemObjectArray__SystemVoid(formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe void internal_UnityEngineDebug__func__LogAssertionFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(global::UnityEngine.Object context, string format, global::System.Object[] args)
        {
            int argsWasmLength = args.Length;
            long[] argsIds = new long[argsWasmLength];
            // Todo: Add handling for non-wrapped objects, currently returning 0 which is null...
            for (int i = 0; i < argsWasmLength; i++) argsIds[i] = (args[i] as IProxyObject)?.WrappedId ?? 0;
            fixed (char* formatPointer = format)
            {
                fixed (long* argsIdsPointer = argsIds)
                {
                    UnityEngineDebug__func__LogAssertionFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(context.WrappedId, formatPointer, format.Length * sizeof(char), argsIdsPointer, argsWasmLength);
                }
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineDebug__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineDebug__get__developerConsoleVisible();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__set__developerConsoleVisible(int developerConsoleVisibleConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineDebug__get__isDebugBuild();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(void* startPointer, void* endPointer, void* colorPointer, float duration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(void* startPointer, void* endPointer, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* startPointer, void* endPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawLine__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(void* startPointer, void* endPointer, void* colorPointer, float duration, int depthTestConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemVoid(void* startPointer, void* dirPointer, void* colorPointer, float duration);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemVoid(void* startPointer, void* dirPointer, void* colorPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__SystemVoid(void* startPointer, void* dirPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__DrawRay__UnityEngineVector3__UnityEngineVector3__UnityEngineColor__SystemSingle__SystemBoolean__SystemVoid(void* startPointer, void* dirPointer, void* colorPointer, float duration, int depthTestConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__Break__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__DebugBreak__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__Log__SystemObject__UnityEngineObject__SystemVoid(long messageObjectId, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogFormat__SystemString__SystemObjectArray__SystemVoid(void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(long contextObjectId, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogFormat__UnityEngineLogTypeEnum__UnityEngineLogOptionEnum__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(int logTypeUnderlyingValue, int logOptionsUnderlyingValue, long contextObjectId, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__LogError__SystemObject__UnityEngineObject__SystemVoid(long messageObjectId, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogErrorFormat__SystemString__SystemObjectArray__SystemVoid(void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogErrorFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(long contextObjectId, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__ClearDeveloperConsole__SystemVoid();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__LogException__SystemException__SystemVoid(long exceptionObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__LogException__SystemException__UnityEngineObject__SystemVoid(long exceptionObjectId, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__LogWarning__SystemObject__UnityEngineObject__SystemVoid(long messageObjectId, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogWarningFormat__SystemString__SystemObjectArray__SystemVoid(void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogWarningFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(long contextObjectId, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__Assert__SystemBoolean__SystemVoid(int conditionConverted);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__Assert__SystemBoolean__UnityEngineObject__SystemVoid(int conditionConverted, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__SystemVoid(int conditionConverted, long messageObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__Assert__SystemBoolean__SystemString__SystemVoid(int conditionConverted, void* messagePointer, int messageWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__Assert__SystemBoolean__SystemObject__UnityEngineObject__SystemVoid(int conditionConverted, long messageObjectId, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__Assert__SystemBoolean__SystemString__UnityEngineObject__SystemVoid(int conditionConverted, void* messagePointer, int messageWasmLength, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__AssertFormat__SystemBoolean__SystemString__SystemObjectArray__SystemVoid(int conditionConverted, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__AssertFormat__SystemBoolean__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(int conditionConverted, long contextObjectId, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__LogAssertion__SystemObject__SystemVoid(long messageObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern void UnityEngineDebug__func__LogAssertion__SystemObject__UnityEngineObject__SystemVoid(long messageObjectId, long contextObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogAssertionFormat__SystemString__SystemObjectArray__SystemVoid(void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineDebug__func__LogAssertionFormat__UnityEngineObject__SystemString__SystemObjectArray__SystemVoid(long contextObjectId, void* formatPointer, int formatWasmLength, void* argsIdsPointer, int argsWasmLength);

        #endregion Imports
    }
}
