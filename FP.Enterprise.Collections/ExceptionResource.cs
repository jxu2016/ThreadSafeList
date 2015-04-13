﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Enterprise.Collections
{
    internal enum ExceptionResource
    {
        Argument_ImplementIComparable,
        Argument_InvalidType,
        Argument_InvalidArgumentForComparison,
        Argument_InvalidRegistryKeyPermissionCheck,
        ArgumentOutOfRange_NeedNonNegNum,
        Arg_ArrayPlusOffTooSmall,
        Arg_NonZeroLowerBound,
        Arg_RankMultiDimNotSupported,
        Arg_RegKeyDelHive,
        Arg_RegKeyStrLenBug,
        Arg_RegSetStrArrNull,
        Arg_RegSetMismatchedKind,
        Arg_RegSubKeyAbsent,
        Arg_RegSubKeyValueAbsent,
        Argument_AddingDuplicate,
        Serialization_InvalidOnDeser,
        Serialization_MissingKeys,
        Serialization_NullKey,
        Argument_InvalidArrayType,
        NotSupported_KeyCollectionSet,
        NotSupported_ValueCollectionSet,
        ArgumentOutOfRange_SmallCapacity,
        ArgumentOutOfRange_Index,
        Argument_InvalidOffLen,
        Argument_ItemNotExist,
        ArgumentOutOfRange_Count,
        ArgumentOutOfRange_InvalidThreshold,
        ArgumentOutOfRange_ListInsert,
        NotSupported_ReadOnlyCollection,
        InvalidOperation_CannotRemoveFromStackOrQueue,
        InvalidOperation_EmptyQueue,
        InvalidOperation_EnumOpCantHappen,
        InvalidOperation_EnumFailedVersion,
        InvalidOperation_EmptyStack,
        ArgumentOutOfRange_BiggerThanCollection,
        InvalidOperation_EnumNotStarted,
        InvalidOperation_EnumEnded,
        NotSupported_SortedListNestedWrite,
        InvalidOperation_NoValue,
        InvalidOperation_RegRemoveSubKey,
        Security_RegistryPermission,
        UnauthorizedAccess_RegistryNoWrite,
        ObjectDisposed_RegKeyClosed,
        NotSupported_InComparableType,
        Argument_InvalidRegistryOptionsCheck,
        Argument_InvalidRegistryViewCheck,
    }
}
