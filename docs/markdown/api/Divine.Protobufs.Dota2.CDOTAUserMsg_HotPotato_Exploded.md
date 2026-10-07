# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded"></a> Class CDOTAUserMsg\_HotPotato\_Exploded

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HotPotato_Exploded : IMessage<CDOTAUserMsg_HotPotato_Exploded>, IEquatable<CDOTAUserMsg_HotPotato_Exploded>, IDeepCloneable<CDOTAUserMsg_HotPotato_Exploded>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HotPotato\_Exploded](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Exploded.md)

#### Implements

IMessage<CDOTAUserMsg\_HotPotato\_Exploded\>, 
[IEquatable<CDOTAUserMsg\_HotPotato\_Exploded\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HotPotato\_Exploded\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HotPotato\_Exploded\>\(CDOTAUserMsg\_HotPotato\_Exploded, params CDOTAUserMsg\_HotPotato\_Exploded\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded__ctor"></a> CDOTAUserMsg\_HotPotato\_Exploded\(\)

```csharp
public CDOTAUserMsg_HotPotato_Exploded()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_"></a> CDOTAUserMsg\_HotPotato\_Exploded\(CDOTAUserMsg\_HotPotato\_Exploded\)

```csharp
public CDOTAUserMsg_HotPotato_Exploded(CDOTAUserMsg_HotPotato_Exploded other)
```

#### Parameters

`other` [CDOTAUserMsg\_HotPotato\_Exploded](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Exploded.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HotPotato_Exploded> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HotPotato\_Exploded](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Exploded.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HotPotato_Exploded Clone()
```

#### Returns

 [CDOTAUserMsg\_HotPotato\_Exploded](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Exploded.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_"></a> Equals\(CDOTAUserMsg\_HotPotato\_Exploded\)

```csharp
public bool Equals(CDOTAUserMsg_HotPotato_Exploded other)
```

#### Parameters

`other` [CDOTAUserMsg\_HotPotato\_Exploded](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Exploded.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_"></a> MergeFrom\(CDOTAUserMsg\_HotPotato\_Exploded\)

```csharp
public void MergeFrom(CDOTAUserMsg_HotPotato_Exploded other)
```

#### Parameters

`other` [CDOTAUserMsg\_HotPotato\_Exploded](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Exploded.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Exploded_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

