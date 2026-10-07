# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member"></a> Class CMsgDOTATeamInfo.Types.Member

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInfo.Types.Member : IMessage<CMsgDOTATeamInfo.Types.Member>, IEquatable<CMsgDOTATeamInfo.Types.Member>, IDeepCloneable<CMsgDOTATeamInfo.Types.Member>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInfo.Types.Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)

#### Implements

IMessage<CMsgDOTATeamInfo.Types.Member\>, 
[IEquatable<CMsgDOTATeamInfo.Types.Member\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInfo.Types.Member\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInfo.Types.Member\>\(CMsgDOTATeamInfo.Types.Member, params CMsgDOTATeamInfo.Types.Member\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member__ctor"></a> Member\(\)

```csharp
public Member()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_"></a> Member\(Member\)

```csharp
public Member(CMsgDOTATeamInfo.Types.Member other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_AdminFieldNumber"></a> AdminFieldNumber

```csharp
public const int AdminFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ProNameFieldNumber"></a> ProNameFieldNumber

```csharp
public const int ProNameFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_RealNameFieldNumber"></a> RealNameFieldNumber

```csharp
public const int RealNameFieldNumber = 9
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_RoleFieldNumber"></a> RoleFieldNumber

```csharp
public const int RoleFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_TimeJoinedFieldNumber"></a> TimeJoinedFieldNumber

```csharp
public const int TimeJoinedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Admin"></a> Admin

```csharp
public bool Admin { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_HasAdmin"></a> HasAdmin

```csharp
public bool HasAdmin { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_HasProName"></a> HasProName

```csharp
public bool HasProName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_HasRealName"></a> HasRealName

```csharp
public bool HasRealName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_HasRole"></a> HasRole

```csharp
public bool HasRole { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_HasTimeJoined"></a> HasTimeJoined

```csharp
public bool HasTimeJoined { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInfo.Types.Member> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ProName"></a> ProName

```csharp
public string ProName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_RealName"></a> RealName

```csharp
public string RealName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Role"></a> Role

```csharp
public Fantasy_Roles Role { get; set; }
```

#### Property Value

 [Fantasy\_Roles](Divine.Protobufs.Dota2.Fantasy\_Roles.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_TimeJoined"></a> TimeJoined

```csharp
public uint TimeJoined { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ClearAdmin"></a> ClearAdmin\(\)

```csharp
public void ClearAdmin()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ClearProName"></a> ClearProName\(\)

```csharp
public void ClearProName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ClearRealName"></a> ClearRealName\(\)

```csharp
public void ClearRealName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ClearRole"></a> ClearRole\(\)

```csharp
public void ClearRole()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ClearTimeJoined"></a> ClearTimeJoined\(\)

```csharp
public void ClearTimeJoined()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInfo.Types.Member Clone()
```

#### Returns

 [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_"></a> Equals\(Member\)

```csharp
public bool Equals(CMsgDOTATeamInfo.Types.Member other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_"></a> MergeFrom\(Member\)

```csharp
public void MergeFrom(CMsgDOTATeamInfo.Types.Member other)
```

#### Parameters

`other` [CMsgDOTATeamInfo](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.md).[Member](Divine.Protobufs.Dota2.CMsgDOTATeamInfo.Types.Member.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInfo_Types_Member_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

