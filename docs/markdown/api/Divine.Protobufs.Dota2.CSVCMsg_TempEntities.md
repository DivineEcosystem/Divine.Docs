# <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities"></a> Class CSVCMsg\_TempEntities

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSVCMsg_TempEntities : IMessage<CSVCMsg_TempEntities>, IEquatable<CSVCMsg_TempEntities>, IDeepCloneable<CSVCMsg_TempEntities>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSVCMsg\_TempEntities](Divine.Protobufs.Dota2.CSVCMsg\_TempEntities.md)

#### Implements

IMessage<CSVCMsg\_TempEntities\>, 
[IEquatable<CSVCMsg\_TempEntities\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSVCMsg\_TempEntities\>, 
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
[EnumerableExtensions.In<CSVCMsg\_TempEntities\>\(CSVCMsg\_TempEntities, params CSVCMsg\_TempEntities\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities__ctor"></a> CSVCMsg\_TempEntities\(\)

```csharp
public CSVCMsg_TempEntities()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities__ctor_Divine_Protobufs_Dota2_CSVCMsg_TempEntities_"></a> CSVCMsg\_TempEntities\(CSVCMsg\_TempEntities\)

```csharp
public CSVCMsg_TempEntities(CSVCMsg_TempEntities other)
```

#### Parameters

`other` [CSVCMsg\_TempEntities](Divine.Protobufs.Dota2.CSVCMsg\_TempEntities.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_EntityDataFieldNumber"></a> EntityDataFieldNumber

```csharp
public const int EntityDataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_NumEntriesFieldNumber"></a> NumEntriesFieldNumber

```csharp
public const int NumEntriesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_ReliableFieldNumber"></a> ReliableFieldNumber

```csharp
public const int ReliableFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_EntityData"></a> EntityData

```csharp
public ByteString EntityData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_HasEntityData"></a> HasEntityData

```csharp
public bool HasEntityData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_HasNumEntries"></a> HasNumEntries

```csharp
public bool HasNumEntries { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_HasReliable"></a> HasReliable

```csharp
public bool HasReliable { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_NumEntries"></a> NumEntries

```csharp
public int NumEntries { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_Parser"></a> Parser

```csharp
public static MessageParser<CSVCMsg_TempEntities> Parser { get; }
```

#### Property Value

 MessageParser<[CSVCMsg\_TempEntities](Divine.Protobufs.Dota2.CSVCMsg\_TempEntities.md)\>

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_Reliable"></a> Reliable

```csharp
public bool Reliable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_ClearEntityData"></a> ClearEntityData\(\)

```csharp
public void ClearEntityData()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_ClearNumEntries"></a> ClearNumEntries\(\)

```csharp
public void ClearNumEntries()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_ClearReliable"></a> ClearReliable\(\)

```csharp
public void ClearReliable()
```

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_Clone"></a> Clone\(\)

```csharp
public CSVCMsg_TempEntities Clone()
```

#### Returns

 [CSVCMsg\_TempEntities](Divine.Protobufs.Dota2.CSVCMsg\_TempEntities.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_Equals_Divine_Protobufs_Dota2_CSVCMsg_TempEntities_"></a> Equals\(CSVCMsg\_TempEntities\)

```csharp
public bool Equals(CSVCMsg_TempEntities other)
```

#### Parameters

`other` [CSVCMsg\_TempEntities](Divine.Protobufs.Dota2.CSVCMsg\_TempEntities.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_MergeFrom_Divine_Protobufs_Dota2_CSVCMsg_TempEntities_"></a> MergeFrom\(CSVCMsg\_TempEntities\)

```csharp
public void MergeFrom(CSVCMsg_TempEntities other)
```

#### Parameters

`other` [CSVCMsg\_TempEntities](Divine.Protobufs.Dota2.CSVCMsg\_TempEntities.md)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSVCMsg_TempEntities_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

