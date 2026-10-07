# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee"></a> Class CMsgDOTATeamInvite\_GCRequestToInvitee

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInvite_GCRequestToInvitee : IMessage<CMsgDOTATeamInvite_GCRequestToInvitee>, IEquatable<CMsgDOTATeamInvite_GCRequestToInvitee>, IDeepCloneable<CMsgDOTATeamInvite_GCRequestToInvitee>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInvite\_GCRequestToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCRequestToInvitee.md)

#### Implements

IMessage<CMsgDOTATeamInvite\_GCRequestToInvitee\>, 
[IEquatable<CMsgDOTATeamInvite\_GCRequestToInvitee\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInvite\_GCRequestToInvitee\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInvite\_GCRequestToInvitee\>\(CMsgDOTATeamInvite\_GCRequestToInvitee, params CMsgDOTATeamInvite\_GCRequestToInvitee\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee__ctor"></a> CMsgDOTATeamInvite\_GCRequestToInvitee\(\)

```csharp
public CMsgDOTATeamInvite_GCRequestToInvitee()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_"></a> CMsgDOTATeamInvite\_GCRequestToInvitee\(CMsgDOTATeamInvite\_GCRequestToInvitee\)

```csharp
public CMsgDOTATeamInvite_GCRequestToInvitee(CMsgDOTATeamInvite_GCRequestToInvitee other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCRequestToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCRequestToInvitee.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_InviterAccountIdFieldNumber"></a> InviterAccountIdFieldNumber

```csharp
public const int InviterAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_LogoFieldNumber"></a> LogoFieldNumber

```csharp
public const int LogoFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_TeamTagFieldNumber"></a> TeamTagFieldNumber

```csharp
public const int TeamTagFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_HasInviterAccountId"></a> HasInviterAccountId

```csharp
public bool HasInviterAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_HasLogo"></a> HasLogo

```csharp
public bool HasLogo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_HasTeamTag"></a> HasTeamTag

```csharp
public bool HasTeamTag { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_InviterAccountId"></a> InviterAccountId

```csharp
public uint InviterAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_Logo"></a> Logo

```csharp
public ulong Logo { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInvite_GCRequestToInvitee> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInvite\_GCRequestToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCRequestToInvitee.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_TeamTag"></a> TeamTag

```csharp
public string TeamTag { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_ClearInviterAccountId"></a> ClearInviterAccountId\(\)

```csharp
public void ClearInviterAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_ClearLogo"></a> ClearLogo\(\)

```csharp
public void ClearLogo()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_ClearTeamTag"></a> ClearTeamTag\(\)

```csharp
public void ClearTeamTag()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInvite_GCRequestToInvitee Clone()
```

#### Returns

 [CMsgDOTATeamInvite\_GCRequestToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCRequestToInvitee.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_"></a> Equals\(CMsgDOTATeamInvite\_GCRequestToInvitee\)

```csharp
public bool Equals(CMsgDOTATeamInvite_GCRequestToInvitee other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCRequestToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCRequestToInvitee.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_"></a> MergeFrom\(CMsgDOTATeamInvite\_GCRequestToInvitee\)

```csharp
public void MergeFrom(CMsgDOTATeamInvite_GCRequestToInvitee other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCRequestToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCRequestToInvitee.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCRequestToInvitee_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

