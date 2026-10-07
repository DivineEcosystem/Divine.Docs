# <a id="Divine_Network_GC_GCProtobuf"></a> Class GCProtobuf

Namespace: [Divine.Network.GC](Divine.Network.GC.md)  
Assembly: Divine.dll  

```csharp
public sealed class GCProtobuf : Protobuf
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Protobuf](Divine.Network.Protobuf.md) ← 
[GCProtobuf](Divine.Network.GC.GCProtobuf.md)

#### Inherited Members

[Protobuf.IsValid](Divine.Network.Protobuf.md\#Divine\_Network\_Protobuf\_IsValid), 
[Protobuf.Id](Divine.Network.Protobuf.md\#Divine\_Network\_Protobuf\_Id), 
[Protobuf.Name](Divine.Network.Protobuf.md\#Divine\_Network\_Protobuf\_Name), 
[Protobuf.Buffer](Divine.Network.Protobuf.md\#Divine\_Network\_Protobuf\_Buffer), 
[Protobuf.ToJson\(\)](Divine.Network.Protobuf.md\#Divine\_Network\_Protobuf\_ToJson), 
[Protobuf.ToString\(\)](Divine.Network.Protobuf.md\#Divine\_Network\_Protobuf\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<GCProtobuf\>\(GCProtobuf, params GCProtobuf\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Network_GC_GCProtobuf_Buffer"></a> Buffer

```csharp
[JsonIgnore]
public override ReadOnlySpan<byte> Buffer { get; }
```

#### Property Value

 [ReadOnlySpan](https://learn.microsoft.com/dotnet/api/system.readonlyspan\-1)<[byte](https://learn.microsoft.com/dotnet/api/system.byte)\>

### <a id="Divine_Network_GC_GCProtobuf_Id"></a> Id

```csharp
[JsonIgnore]
public override int Id { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Network_GC_GCProtobuf_MessageId"></a> MessageId

```csharp
public GCMessageId MessageId { get; }
```

#### Property Value

 [GCMessageId](Divine.Network.GC.GCMessageId.md)

### <a id="Divine_Network_GC_GCProtobuf_Name"></a> Name

```csharp
public override string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Network_GC_GCProtobuf_RawMessageId"></a> RawMessageId

```csharp
public GCRawMessageId RawMessageId { get; }
```

#### Property Value

 [GCRawMessageId](Divine.Network.GC.GCRawMessageId.md)

## Methods

### <a id="Divine_Network_GC_GCProtobuf_ToJson"></a> ToJson\(\)

```csharp
public override JsonNode? ToJson()
```

#### Returns

 [JsonNode](https://learn.microsoft.com/dotnet/api/system.text.json.nodes.jsonnode)?

### <a id="Divine_Network_GC_GCProtobuf_ToString"></a> ToString\(\)

Returns a string that represents the current object.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

A string that represents the current object.

