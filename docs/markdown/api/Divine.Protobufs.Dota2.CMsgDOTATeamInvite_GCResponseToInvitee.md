# <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee"></a> Class CMsgDOTATeamInvite\_GCResponseToInvitee

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATeamInvite_GCResponseToInvitee : IMessage<CMsgDOTATeamInvite_GCResponseToInvitee>, IEquatable<CMsgDOTATeamInvite_GCResponseToInvitee>, IDeepCloneable<CMsgDOTATeamInvite_GCResponseToInvitee>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATeamInvite\_GCResponseToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInvitee.md)

#### Implements

IMessage<CMsgDOTATeamInvite\_GCResponseToInvitee\>, 
[IEquatable<CMsgDOTATeamInvite\_GCResponseToInvitee\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATeamInvite\_GCResponseToInvitee\>, 
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
[EnumerableExtensions.In<CMsgDOTATeamInvite\_GCResponseToInvitee\>\(CMsgDOTATeamInvite\_GCResponseToInvitee, params CMsgDOTATeamInvite\_GCResponseToInvitee\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee__ctor"></a> CMsgDOTATeamInvite\_GCResponseToInvitee\(\)

```csharp
public CMsgDOTATeamInvite_GCResponseToInvitee()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee__ctor_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_"></a> CMsgDOTATeamInvite\_GCResponseToInvitee\(CMsgDOTATeamInvite\_GCResponseToInvitee\)

```csharp
public CMsgDOTATeamInvite_GCResponseToInvitee(CMsgDOTATeamInvite_GCResponseToInvitee other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCResponseToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInvitee.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_TeamNameFieldNumber"></a> TeamNameFieldNumber

```csharp
public const int TeamNameFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_HasTeamName"></a> HasTeamName

```csharp
public bool HasTeamName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATeamInvite_GCResponseToInvitee> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATeamInvite\_GCResponseToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInvitee.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_Result"></a> Result

```csharp
public ETeamInviteResult Result { get; set; }
```

#### Property Value

 [ETeamInviteResult](Divine.Protobufs.Dota2.ETeamInviteResult.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_TeamName"></a> TeamName

```csharp
public string TeamName { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_ClearTeamName"></a> ClearTeamName\(\)

```csharp
public void ClearTeamName()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATeamInvite_GCResponseToInvitee Clone()
```

#### Returns

 [CMsgDOTATeamInvite\_GCResponseToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInvitee.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_Equals_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_"></a> Equals\(CMsgDOTATeamInvite\_GCResponseToInvitee\)

```csharp
public bool Equals(CMsgDOTATeamInvite_GCResponseToInvitee other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCResponseToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInvitee.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_"></a> MergeFrom\(CMsgDOTATeamInvite\_GCResponseToInvitee\)

```csharp
public void MergeFrom(CMsgDOTATeamInvite_GCResponseToInvitee other)
```

#### Parameters

`other` [CMsgDOTATeamInvite\_GCResponseToInvitee](Divine.Protobufs.Dota2.CMsgDOTATeamInvite\_GCResponseToInvitee.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATeamInvite_GCResponseToInvitee_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

