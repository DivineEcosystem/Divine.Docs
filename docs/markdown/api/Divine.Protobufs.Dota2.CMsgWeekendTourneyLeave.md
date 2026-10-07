# <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave"></a> Class CMsgWeekendTourneyLeave

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgWeekendTourneyLeave : IMessage<CMsgWeekendTourneyLeave>, IEquatable<CMsgWeekendTourneyLeave>, IDeepCloneable<CMsgWeekendTourneyLeave>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgWeekendTourneyLeave](Divine.Protobufs.Dota2.CMsgWeekendTourneyLeave.md)

#### Implements

IMessage<CMsgWeekendTourneyLeave\>, 
[IEquatable<CMsgWeekendTourneyLeave\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgWeekendTourneyLeave\>, 
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
[EnumerableExtensions.In<CMsgWeekendTourneyLeave\>\(CMsgWeekendTourneyLeave, params CMsgWeekendTourneyLeave\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave__ctor"></a> CMsgWeekendTourneyLeave\(\)

```csharp
public CMsgWeekendTourneyLeave()
```

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave__ctor_Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_"></a> CMsgWeekendTourneyLeave\(CMsgWeekendTourneyLeave\)

```csharp
public CMsgWeekendTourneyLeave(CMsgWeekendTourneyLeave other)
```

#### Parameters

`other` [CMsgWeekendTourneyLeave](Divine.Protobufs.Dota2.CMsgWeekendTourneyLeave.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_Parser"></a> Parser

```csharp
public static MessageParser<CMsgWeekendTourneyLeave> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgWeekendTourneyLeave](Divine.Protobufs.Dota2.CMsgWeekendTourneyLeave.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_Clone"></a> Clone\(\)

```csharp
public CMsgWeekendTourneyLeave Clone()
```

#### Returns

 [CMsgWeekendTourneyLeave](Divine.Protobufs.Dota2.CMsgWeekendTourneyLeave.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_Equals_Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_"></a> Equals\(CMsgWeekendTourneyLeave\)

```csharp
public bool Equals(CMsgWeekendTourneyLeave other)
```

#### Parameters

`other` [CMsgWeekendTourneyLeave](Divine.Protobufs.Dota2.CMsgWeekendTourneyLeave.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_MergeFrom_Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_"></a> MergeFrom\(CMsgWeekendTourneyLeave\)

```csharp
public void MergeFrom(CMsgWeekendTourneyLeave other)
```

#### Parameters

`other` [CMsgWeekendTourneyLeave](Divine.Protobufs.Dota2.CMsgWeekendTourneyLeave.md)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgWeekendTourneyLeave_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

