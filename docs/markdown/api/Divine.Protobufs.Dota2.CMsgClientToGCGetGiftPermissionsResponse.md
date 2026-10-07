# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse"></a> Class CMsgClientToGCGetGiftPermissionsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetGiftPermissionsResponse : IMessage<CMsgClientToGCGetGiftPermissionsResponse>, IEquatable<CMsgClientToGCGetGiftPermissionsResponse>, IDeepCloneable<CMsgClientToGCGetGiftPermissionsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md)

#### Implements

IMessage<CMsgClientToGCGetGiftPermissionsResponse\>, 
[IEquatable<CMsgClientToGCGetGiftPermissionsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetGiftPermissionsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetGiftPermissionsResponse\>\(CMsgClientToGCGetGiftPermissionsResponse, params CMsgClientToGCGetGiftPermissionsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse__ctor"></a> CMsgClientToGCGetGiftPermissionsResponse\(\)

```csharp
public CMsgClientToGCGetGiftPermissionsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_"></a> CMsgClientToGCGetGiftPermissionsResponse\(CMsgClientToGCGetGiftPermissionsResponse\)

```csharp
public CMsgClientToGCGetGiftPermissionsResponse(CMsgClientToGCGetGiftPermissionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_FriendPermissionsFieldNumber"></a> FriendPermissionsFieldNumber

```csharp
public const int FriendPermissionsFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_FriendshipAgeRequirementFieldNumber"></a> FriendshipAgeRequirementFieldNumber

```csharp
public const int FriendshipAgeRequirementFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_FriendshipAgeRequirementTwoFactorFieldNumber"></a> FriendshipAgeRequirementTwoFactorFieldNumber

```csharp
public const int FriendshipAgeRequirementTwoFactorFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasTwoFactorFieldNumber"></a> HasTwoFactorFieldNumber

```csharp
public const int HasTwoFactorFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_IsUnlimitedFieldNumber"></a> IsUnlimitedFieldNumber

```csharp
public const int IsUnlimitedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_SenderPermissionFieldNumber"></a> SenderPermissionFieldNumber

```csharp
public const int SenderPermissionFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_FriendPermissions"></a> FriendPermissions

```csharp
public RepeatedField<CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission> FriendPermissions { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.md).[FriendPermission](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.Types.FriendPermission.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_FriendshipAgeRequirement"></a> FriendshipAgeRequirement

```csharp
public uint FriendshipAgeRequirement { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_FriendshipAgeRequirementTwoFactor"></a> FriendshipAgeRequirementTwoFactor

```csharp
public uint FriendshipAgeRequirementTwoFactor { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasFriendshipAgeRequirement"></a> HasFriendshipAgeRequirement

```csharp
public bool HasFriendshipAgeRequirement { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasFriendshipAgeRequirementTwoFactor"></a> HasFriendshipAgeRequirementTwoFactor

```csharp
public bool HasFriendshipAgeRequirementTwoFactor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasHasTwoFactor"></a> HasHasTwoFactor

```csharp
public bool HasHasTwoFactor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasIsUnlimited"></a> HasIsUnlimited

```csharp
public bool HasIsUnlimited { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasSenderPermission"></a> HasSenderPermission

```csharp
public bool HasSenderPermission { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_HasTwoFactor"></a> HasTwoFactor

```csharp
public bool HasTwoFactor { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_IsUnlimited"></a> IsUnlimited

```csharp
public bool IsUnlimited { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetGiftPermissionsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_SenderPermission"></a> SenderPermission

```csharp
public EGCMsgInitiateTradeResponse SenderPermission { get; set; }
```

#### Property Value

 [EGCMsgInitiateTradeResponse](Divine.Protobufs.Dota2.EGCMsgInitiateTradeResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_ClearFriendshipAgeRequirement"></a> ClearFriendshipAgeRequirement\(\)

```csharp
public void ClearFriendshipAgeRequirement()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_ClearFriendshipAgeRequirementTwoFactor"></a> ClearFriendshipAgeRequirementTwoFactor\(\)

```csharp
public void ClearFriendshipAgeRequirementTwoFactor()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_ClearHasTwoFactor"></a> ClearHasTwoFactor\(\)

```csharp
public void ClearHasTwoFactor()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_ClearIsUnlimited"></a> ClearIsUnlimited\(\)

```csharp
public void ClearIsUnlimited()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_ClearSenderPermission"></a> ClearSenderPermission\(\)

```csharp
public void ClearSenderPermission()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetGiftPermissionsResponse Clone()
```

#### Returns

 [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_"></a> Equals\(CMsgClientToGCGetGiftPermissionsResponse\)

```csharp
public bool Equals(CMsgClientToGCGetGiftPermissionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_"></a> MergeFrom\(CMsgClientToGCGetGiftPermissionsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetGiftPermissionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetGiftPermissionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetGiftPermissionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetGiftPermissionsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

