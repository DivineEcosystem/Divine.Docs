# <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus"></a> Class CMsgTeamFanContentAutographStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanContentAutographStatus : IMessage<CMsgTeamFanContentAutographStatus>, IEquatable<CMsgTeamFanContentAutographStatus>, IDeepCloneable<CMsgTeamFanContentAutographStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md)

#### Implements

IMessage<CMsgTeamFanContentAutographStatus\>, 
[IEquatable<CMsgTeamFanContentAutographStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanContentAutographStatus\>, 
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
[EnumerableExtensions.In<CMsgTeamFanContentAutographStatus\>\(CMsgTeamFanContentAutographStatus, params CMsgTeamFanContentAutographStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus__ctor"></a> CMsgTeamFanContentAutographStatus\(\)

```csharp
public CMsgTeamFanContentAutographStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus__ctor_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_"></a> CMsgTeamFanContentAutographStatus\(CMsgTeamFanContentAutographStatus\)

```csharp
public CMsgTeamFanContentAutographStatus(CMsgTeamFanContentAutographStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_TeamAutographsFieldNumber"></a> TeamAutographsFieldNumber

```csharp
public const int TeamAutographsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanContentAutographStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_TeamAutographs"></a> TeamAutographs

```csharp
public RepeatedField<CMsgTeamFanContentAutographStatus.Types.TeamStatus> TeamAutographs { get; }
```

#### Property Value

 RepeatedField<[CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.Types.TeamStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanContentAutographStatus Clone()
```

#### Returns

 [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_Equals_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_"></a> Equals\(CMsgTeamFanContentAutographStatus\)

```csharp
public bool Equals(CMsgTeamFanContentAutographStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_"></a> MergeFrom\(CMsgTeamFanContentAutographStatus\)

```csharp
public void MergeFrom(CMsgTeamFanContentAutographStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentAutographStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentAutographStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentAutographStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

