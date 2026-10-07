# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates"></a> Class CMsgClientToGCRequestReporterUpdates

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestReporterUpdates : IMessage<CMsgClientToGCRequestReporterUpdates>, IEquatable<CMsgClientToGCRequestReporterUpdates>, IDeepCloneable<CMsgClientToGCRequestReporterUpdates>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestReporterUpdates](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdates.md)

#### Implements

IMessage<CMsgClientToGCRequestReporterUpdates\>, 
[IEquatable<CMsgClientToGCRequestReporterUpdates\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestReporterUpdates\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestReporterUpdates\>\(CMsgClientToGCRequestReporterUpdates, params CMsgClientToGCRequestReporterUpdates\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates__ctor"></a> CMsgClientToGCRequestReporterUpdates\(\)

```csharp
public CMsgClientToGCRequestReporterUpdates()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_"></a> CMsgClientToGCRequestReporterUpdates\(CMsgClientToGCRequestReporterUpdates\)

```csharp
public CMsgClientToGCRequestReporterUpdates(CMsgClientToGCRequestReporterUpdates other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdates](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdates.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestReporterUpdates> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestReporterUpdates](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdates.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestReporterUpdates Clone()
```

#### Returns

 [CMsgClientToGCRequestReporterUpdates](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdates.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_"></a> Equals\(CMsgClientToGCRequestReporterUpdates\)

```csharp
public bool Equals(CMsgClientToGCRequestReporterUpdates other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdates](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdates.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_"></a> MergeFrom\(CMsgClientToGCRequestReporterUpdates\)

```csharp
public void MergeFrom(CMsgClientToGCRequestReporterUpdates other)
```

#### Parameters

`other` [CMsgClientToGCRequestReporterUpdates](Divine.Protobufs.Dota2.CMsgClientToGCRequestReporterUpdates.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestReporterUpdates_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

