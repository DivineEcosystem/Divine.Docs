# <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus"></a> Class CMsgTeamFanContentStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgTeamFanContentStatus : IMessage<CMsgTeamFanContentStatus>, IEquatable<CMsgTeamFanContentStatus>, IDeepCloneable<CMsgTeamFanContentStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md)

#### Implements

IMessage<CMsgTeamFanContentStatus\>, 
[IEquatable<CMsgTeamFanContentStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgTeamFanContentStatus\>, 
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
[EnumerableExtensions.In<CMsgTeamFanContentStatus\>\(CMsgTeamFanContentStatus, params CMsgTeamFanContentStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus__ctor"></a> CMsgTeamFanContentStatus\(\)

```csharp
public CMsgTeamFanContentStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus__ctor_Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_"></a> CMsgTeamFanContentStatus\(CMsgTeamFanContentStatus\)

```csharp
public CMsgTeamFanContentStatus(CMsgTeamFanContentStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_TeamStatusListFieldNumber"></a> TeamStatusListFieldNumber

```csharp
public const int TeamStatusListFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgTeamFanContentStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_TeamStatusList"></a> TeamStatusList

```csharp
public RepeatedField<CMsgTeamFanContentStatus.Types.TeamStatus> TeamStatusList { get; }
```

#### Property Value

 RepeatedField<[CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md).[Types](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.md).[TeamStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.Types.TeamStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Clone"></a> Clone\(\)

```csharp
public CMsgTeamFanContentStatus Clone()
```

#### Returns

 [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_Equals_Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_"></a> Equals\(CMsgTeamFanContentStatus\)

```csharp
public bool Equals(CMsgTeamFanContentStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_"></a> MergeFrom\(CMsgTeamFanContentStatus\)

```csharp
public void MergeFrom(CMsgTeamFanContentStatus other)
```

#### Parameters

`other` [CMsgTeamFanContentStatus](Divine.Protobufs.Dota2.CMsgTeamFanContentStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgTeamFanContentStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

