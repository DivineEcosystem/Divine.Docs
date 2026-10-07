# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause"></a> Class CDOTAClientMsg\_Pause

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_Pause : IMessage<CDOTAClientMsg_Pause>, IEquatable<CDOTAClientMsg_Pause>, IDeepCloneable<CDOTAClientMsg_Pause>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_Pause](Divine.Protobufs.Dota2.CDOTAClientMsg\_Pause.md)

#### Implements

IMessage<CDOTAClientMsg\_Pause\>, 
[IEquatable<CDOTAClientMsg\_Pause\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_Pause\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_Pause\>\(CDOTAClientMsg\_Pause, params CDOTAClientMsg\_Pause\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause__ctor"></a> CDOTAClientMsg\_Pause\(\)

```csharp
public CDOTAClientMsg_Pause()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_"></a> CDOTAClientMsg\_Pause\(CDOTAClientMsg\_Pause\)

```csharp
public CDOTAClientMsg_Pause(CDOTAClientMsg_Pause other)
```

#### Parameters

`other` [CDOTAClientMsg\_Pause](Divine.Protobufs.Dota2.CDOTAClientMsg\_Pause.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_Pause> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_Pause](Divine.Protobufs.Dota2.CDOTAClientMsg\_Pause.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_Pause Clone()
```

#### Returns

 [CDOTAClientMsg\_Pause](Divine.Protobufs.Dota2.CDOTAClientMsg\_Pause.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_"></a> Equals\(CDOTAClientMsg\_Pause\)

```csharp
public bool Equals(CDOTAClientMsg_Pause other)
```

#### Parameters

`other` [CDOTAClientMsg\_Pause](Divine.Protobufs.Dota2.CDOTAClientMsg\_Pause.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_"></a> MergeFrom\(CDOTAClientMsg\_Pause\)

```csharp
public void MergeFrom(CDOTAClientMsg_Pause other)
```

#### Parameters

`other` [CDOTAClientMsg\_Pause](Divine.Protobufs.Dota2.CDOTAClientMsg\_Pause.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_Pause_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

