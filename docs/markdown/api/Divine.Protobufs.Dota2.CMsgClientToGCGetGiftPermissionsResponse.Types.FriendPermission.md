# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission"></a> Class CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission : IMessage<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission>, IEquatable<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission>, IDeepCloneable<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)

#### Implements

IMessage<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission\>, 
[IEquatable<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission\>\(CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission, params CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission__ctor"></a> FriendPermission\(\)

```csharp
public FriendPermission()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_"></a> FriendPermission\(FriendPermission\)

```csharp
public FriendPermission(CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission other)
```

#### Parameters

`other` [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.md).[FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_PermissionFieldNumber"></a> PermissionFieldNumber

```csharp
public const int PermissionFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_HasPermission"></a> HasPermission

```csharp
public bool HasPermission { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.md).[FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_Permission"></a> Permission

```csharp
public EGCMsgInitiateTradeResponse Permission { get; set; }
```

#### Property Value

 [EGCMsgInitiateTradeResponse](Divine.Protobufs.Dota2.EGCMsgInitiateTradeResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_ClearPermission"></a> ClearPermission\(\)

```csharp
public void ClearPermission()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission Clone()
```

#### Returns

 [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.md).[FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_"></a> Equals\(FriendPermission\)

```csharp
public bool Equals(CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission other)
```

#### Parameters

`other` [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.md).[FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_"></a> MergeFrom\(FriendPermission\)

```csharp
public void MergeFrom(CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission other)
```

#### Parameters

`other` [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.md).[FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Types_FriendPermission_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

