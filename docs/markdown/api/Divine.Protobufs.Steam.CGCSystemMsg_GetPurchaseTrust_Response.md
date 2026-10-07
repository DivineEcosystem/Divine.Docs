# <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response"></a> Class CGCSystemMsg\_GetPurchaseTrust\_Response

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CGCSystemMsg_GetPurchaseTrust_Response : IMessage<CGCSystemMsg_GetPurchaseTrust_Response>, IEquatable<CGCSystemMsg_GetPurchaseTrust_Response>, IDeepCloneable<CGCSystemMsg_GetPurchaseTrust_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CGCSystemMsg\_GetPurchaseTrust\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetPurchaseTrust\_Response.md)

#### Implements

IMessage<CGCSystemMsg\_GetPurchaseTrust\_Response\>, 
[IEquatable<CGCSystemMsg\_GetPurchaseTrust\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CGCSystemMsg\_GetPurchaseTrust\_Response\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CGCSystemMsg\_GetPurchaseTrust\_Response\>\(CGCSystemMsg\_GetPurchaseTrust\_Response, params CGCSystemMsg\_GetPurchaseTrust\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response__ctor"></a> CGCSystemMsg\_GetPurchaseTrust\_Response\(\)

```csharp
public CGCSystemMsg_GetPurchaseTrust_Response()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response__ctor_Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_"></a> CGCSystemMsg\_GetPurchaseTrust\_Response\(CGCSystemMsg\_GetPurchaseTrust\_Response\)

```csharp
public CGCSystemMsg_GetPurchaseTrust_Response(CGCSystemMsg_GetPurchaseTrust_Response other)
```

#### Parameters

`other` [CGCSystemMsg\_GetPurchaseTrust\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetPurchaseTrust\_Response.md)

## Fields

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasNoRecentPasswordResetsFieldNumber"></a> HasNoRecentPasswordResetsFieldNumber

```csharp
public const int HasNoRecentPasswordResetsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasPriorPurchaseHistoryFieldNumber"></a> HasPriorPurchaseHistoryFieldNumber

```csharp
public const int HasPriorPurchaseHistoryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_IsWalletCashTrustedFieldNumber"></a> IsWalletCashTrustedFieldNumber

```csharp
public const int IsWalletCashTrustedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_TimeAllTrustedFieldNumber"></a> TimeAllTrustedFieldNumber

```csharp
public const int TimeAllTrustedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasHasNoRecentPasswordResets"></a> HasHasNoRecentPasswordResets

```csharp
public bool HasHasNoRecentPasswordResets { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasHasPriorPurchaseHistory"></a> HasHasPriorPurchaseHistory

```csharp
public bool HasHasPriorPurchaseHistory { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasIsWalletCashTrusted"></a> HasIsWalletCashTrusted

```csharp
public bool HasIsWalletCashTrusted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasNoRecentPasswordResets"></a> HasNoRecentPasswordResets

```csharp
public bool HasNoRecentPasswordResets { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasPriorPurchaseHistory"></a> HasPriorPurchaseHistory

```csharp
public bool HasPriorPurchaseHistory { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_HasTimeAllTrusted"></a> HasTimeAllTrusted

```csharp
public bool HasTimeAllTrusted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_IsWalletCashTrusted"></a> IsWalletCashTrusted

```csharp
public bool IsWalletCashTrusted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_Parser"></a> Parser

```csharp
public static MessageParser<CGCSystemMsg_GetPurchaseTrust_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CGCSystemMsg\_GetPurchaseTrust\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetPurchaseTrust\_Response.md)\>

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_TimeAllTrusted"></a> TimeAllTrusted

```csharp
public uint TimeAllTrusted { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_ClearHasNoRecentPasswordResets"></a> ClearHasNoRecentPasswordResets\(\)

```csharp
public void ClearHasNoRecentPasswordResets()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_ClearHasPriorPurchaseHistory"></a> ClearHasPriorPurchaseHistory\(\)

```csharp
public void ClearHasPriorPurchaseHistory()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_ClearIsWalletCashTrusted"></a> ClearIsWalletCashTrusted\(\)

```csharp
public void ClearIsWalletCashTrusted()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_ClearTimeAllTrusted"></a> ClearTimeAllTrusted\(\)

```csharp
public void ClearTimeAllTrusted()
```

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_Clone"></a> Clone\(\)

```csharp
public CGCSystemMsg_GetPurchaseTrust_Response Clone()
```

#### Returns

 [CGCSystemMsg\_GetPurchaseTrust\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetPurchaseTrust\_Response.md)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_Equals_Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_"></a> Equals\(CGCSystemMsg\_GetPurchaseTrust\_Response\)

```csharp
public bool Equals(CGCSystemMsg_GetPurchaseTrust_Response other)
```

#### Parameters

`other` [CGCSystemMsg\_GetPurchaseTrust\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetPurchaseTrust\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_MergeFrom_Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_"></a> MergeFrom\(CGCSystemMsg\_GetPurchaseTrust\_Response\)

```csharp
public void MergeFrom(CGCSystemMsg_GetPurchaseTrust_Response other)
```

#### Parameters

`other` [CGCSystemMsg\_GetPurchaseTrust\_Response](Divine.Protobufs.Steam.CGCSystemMsg\_GetPurchaseTrust\_Response.md)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CGCSystemMsg_GetPurchaseTrust_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

