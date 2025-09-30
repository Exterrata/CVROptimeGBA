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

    public partial class Collision(long id) : IProxyObject
    {
        public long WrappedId { get; set; } = id;

        #region Implementation

        public Collision()
            : this(internal_UnityEngineCollision__ctor()) { }

        public global::UnityEngine.Vector3 relativeVelocity 
        {
            get => internal_UnityEngineCollision__get__relativeVelocity(WrappedId);
        }

        public global::UnityEngine.Rigidbody rigidbody 
        {
            get => internal_UnityEngineCollision__get__rigidbody(WrappedId);
        }

        public global::UnityEngine.ArticulationBody articulationBody 
        {
            get => internal_UnityEngineCollision__get__articulationBody(WrappedId);
        }

        public global::UnityEngine.Component body 
        {
            get => internal_UnityEngineCollision__get__body(WrappedId);
        }

        public global::UnityEngine.Collider collider 
        {
            get => internal_UnityEngineCollision__get__collider(WrappedId);
        }

        public global::UnityEngine.Transform transform 
        {
            get => internal_UnityEngineCollision__get__transform(WrappedId);
        }

        public global::UnityEngine.GameObject gameObject 
        {
            get => internal_UnityEngineCollision__get__gameObject(WrappedId);
        }

        public int contactCount 
        {
            get => internal_UnityEngineCollision__get__contactCount(WrappedId);
        }

        public global::UnityEngine.ContactPoint[] contacts 
        {
            get => internal_UnityEngineCollision__get__contacts(WrappedId);
        }

        public global::UnityEngine.Vector3 impulse 
        {
            get => internal_UnityEngineCollision__get__impulse(WrappedId);
        }

        public global::UnityEngine.ContactPoint GetContact(int index)
        {
            return internal_UnityEngineCollision__func__GetContact__SystemInt32__UnityEngineContactPoint(WrappedId, index);
        }

        public int GetContacts(global::UnityEngine.ContactPoint[] contacts)
        {
            return internal_UnityEngineCollision__func__GetContacts__UnityEngineContactPointArray__SystemInt32(WrappedId, contacts);
        }

        public int GetContacts(global::System.Collections.Generic.List<global::UnityEngine.ContactPoint> contacts)
        {
            return internal_UnityEngineCollision__func__GetContacts__SystemCollectionsGeneric_List_UnityEngineContactPoint__SystemInt32(WrappedId, contacts);
        }

        #endregion Implementation

        #region Marshaling

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe long internal_UnityEngineCollision__ctor()
        {
            return UnityEngineCollision__ctor();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCollision__get__relativeVelocity(long selfObjectId)
        {
            global::UnityEngine.Vector3 relativeVelocityValue = default;
            UnityEngineCollision__get__relativeVelocity(selfObjectId, Unsafe.AsPointer(ref relativeVelocityValue));
            global::UnityEngine.Vector3 returnResult = relativeVelocityValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Rigidbody internal_UnityEngineCollision__get__rigidbody(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__rigidbody(selfObjectId);
            var returnResult = new global::UnityEngine.Rigidbody(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ArticulationBody internal_UnityEngineCollision__get__articulationBody(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__articulationBody(selfObjectId);
            var returnResult = new global::UnityEngine.ArticulationBody(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Component internal_UnityEngineCollision__get__body(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__body(selfObjectId);
            var returnResult = new global::UnityEngine.Component(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Collider internal_UnityEngineCollision__get__collider(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__collider(selfObjectId);
            var returnResult = new global::UnityEngine.Collider(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Transform internal_UnityEngineCollision__get__transform(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__transform(selfObjectId);
            var returnResult = new global::UnityEngine.Transform(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.GameObject internal_UnityEngineCollision__get__gameObject(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__gameObject(selfObjectId);
            var returnResult = new global::UnityEngine.GameObject(methodCallResult);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCollision__get__contactCount(long selfObjectId)
        {
            var methodCallResult = UnityEngineCollision__get__contactCount(selfObjectId);
            var returnResult = methodCallResult;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ContactPoint[] internal_UnityEngineCollision__get__contacts(long selfObjectId)
        {
            global::UnityEngine.ContactPoint* contactsIdsPointer = default;
            int contactsWasmLength = default;
            UnityEngineCollision__get__contacts(selfObjectId, &contactsIdsPointer, &contactsWasmLength);
            global::UnityEngine.ContactPoint[] returnResult = new global::UnityEngine.ContactPoint[contactsWasmLength];
            for (int i = 0; i < contactsWasmLength; i++)
            {
                returnResult[i] = contactsIdsPointer![i];
            }
            Marshal.FreeHGlobal((IntPtr)contactsIdsPointer);
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.Vector3 internal_UnityEngineCollision__get__impulse(long selfObjectId)
        {
            global::UnityEngine.Vector3 impulseValue = default;
            UnityEngineCollision__get__impulse(selfObjectId, Unsafe.AsPointer(ref impulseValue));
            global::UnityEngine.Vector3 returnResult = impulseValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe global::UnityEngine.ContactPoint internal_UnityEngineCollision__func__GetContact__SystemInt32__UnityEngineContactPoint(long selfObjectId, int index)
        {
            global::UnityEngine.ContactPoint returnResultValue = default;
            UnityEngineCollision__func__GetContact__SystemInt32__UnityEngineContactPoint(selfObjectId, index, Unsafe.AsPointer(ref returnResultValue));
            global::UnityEngine.ContactPoint returnResult = returnResultValue;
            return returnResult;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCollision__func__GetContacts__UnityEngineContactPointArray__SystemInt32(long selfObjectId, global::UnityEngine.ContactPoint[] contacts)
        {
            fixed (global::UnityEngine.ContactPoint* contactsPointer = contacts)
            {
                var methodCallResult = UnityEngineCollision__func__GetContacts__UnityEngineContactPointArray__SystemInt32(selfObjectId, contactsPointer, contacts.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe int internal_UnityEngineCollision__func__GetContacts__SystemCollectionsGeneric_List_UnityEngineContactPoint__SystemInt32(long selfObjectId, global::System.Collections.Generic.List<global::UnityEngine.ContactPoint> contactsList)
        {
            Span<global::UnityEngine.ContactPoint> contacts = CollectionsMarshal.AsSpan(contactsList);
            fixed (global::UnityEngine.ContactPoint* contactsPointer = contacts)
            {
                var methodCallResult = UnityEngineCollision__func__GetContacts__SystemCollectionsGeneric_List_UnityEngineContactPoint__SystemInt32(selfObjectId, contactsPointer, contacts.Length);
                var returnResult = methodCallResult;
                return returnResult;
            }
        }

        #endregion Marshaling

        #region Imports

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__ctor();

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollision__get__relativeVelocity(long selfObjectId, void* relativeVelocityPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__get__rigidbody(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__get__articulationBody(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__get__body(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__get__collider(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__get__transform(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern long UnityEngineCollision__get__gameObject(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern int UnityEngineCollision__get__contactCount(long selfObjectId);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollision__get__contacts(long selfObjectId, void* contactsIdsPointer, void* contactsWasmLengthPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollision__get__impulse(long selfObjectId, void* impulsePointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe void UnityEngineCollision__func__GetContact__SystemInt32__UnityEngineContactPoint(long selfObjectId, int index, void* returnResultPointer);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCollision__func__GetContacts__UnityEngineContactPointArray__SystemInt32(long selfObjectId, void* contactsPointer, int contactsWasmLength);

        [WasmImportLinkage, DllImport("UnityEngine")]
        private static extern unsafe int UnityEngineCollision__func__GetContacts__SystemCollectionsGeneric_List_UnityEngineContactPoint__SystemInt32(long selfObjectId, void* contactsPointer, int contactsWasmLength);

        #endregion Imports
    }
}
