# <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam"></a> Class CMsgDOTALeaveTeam

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTALeaveTeam : IMessage<CMsgDOTALeaveTeam>, IEquatable<CMsgDOTALeaveTeam>, IDeepCloneable<CMsgDOTALeaveTeam>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTALeaveTeam](Divine.Protobufs.Dota2.CMsgDOTALeaveTeam.md)

#### Implements

IMessage<CMsgDOTALeaveTeam\>, 
[IEquatable<CMsgDOTALeaveTeam\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTALeaveTeam\>, 
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
[EnumerableExtensions.In<CMsgDOTALeaveTeam\>\(CMsgDOTALeaveTeam, params CMsgDOTALeaveTeam\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam__ctor"></a> CMsgDOTALeaveTeam\(\)

```csharp
public CMsgDOTALeaveTeam()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam__ctor_Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_"></a> CMsgDOTALeaveTeam\(CMsgDOTALeaveTeam\)

```csharp
public CMsgDOTALeaveTeam(CMsgDOTALeaveTeam other)
```

#### Parameters

`other` [CMsgDOTALeaveTeam](Divine.Protobufs.Dota2.CMsgDOTALeaveTeam.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTALeaveTeam> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTALeaveTeam](Divine.Protobufs.Dota2.CMsgDOTALeaveTeam.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_Clone"></a> Clone\(\)

```csharp
public CMsgDOTALeaveTeam Clone()
```

#### Returns

 [CMsgDOTALeaveTeam](Divine.Protobufs.Dota2.CMsgDOTALeaveTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_Equals_Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_"></a> Equals\(CMsgDOTALeaveTeam\)

```csharp
public bool Equals(CMsgDOTALeaveTeam other)
```

#### Parameters

`other` [CMsgDOTALeaveTeam](Divine.Protobufs.Dota2.CMsgDOTALeaveTeam.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_"></a> MergeFrom\(CMsgDOTALeaveTeam\)

```csharp
public void MergeFrom(CMsgDOTALeaveTeam other)
```

#### Parameters

`other` [CMsgDOTALeaveTeam](Divine.Protobufs.Dota2.CMsgDOTALeaveTeam.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTALeaveTeam_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

