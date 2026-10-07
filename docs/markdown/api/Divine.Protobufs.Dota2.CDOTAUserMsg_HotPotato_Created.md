# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created"></a> Class CDOTAUserMsg\_HotPotato\_Created

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HotPotato_Created : IMessage<CDOTAUserMsg_HotPotato_Created>, IEquatable<CDOTAUserMsg_HotPotato_Created>, IDeepCloneable<CDOTAUserMsg_HotPotato_Created>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HotPotato\_Created](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Created.md)

#### Implements

IMessage<CDOTAUserMsg\_HotPotato\_Created\>, 
[IEquatable<CDOTAUserMsg\_HotPotato\_Created\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HotPotato\_Created\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HotPotato\_Created\>\(CDOTAUserMsg\_HotPotato\_Created, params CDOTAUserMsg\_HotPotato\_Created\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created__ctor"></a> CDOTAUserMsg\_HotPotato\_Created\(\)

```csharp
public CDOTAUserMsg_HotPotato_Created()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_"></a> CDOTAUserMsg\_HotPotato\_Created\(CDOTAUserMsg\_HotPotato\_Created\)

```csharp
public CDOTAUserMsg_HotPotato_Created(CDOTAUserMsg_HotPotato_Created other)
```

#### Parameters

`other` [CDOTAUserMsg\_HotPotato\_Created](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Created.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_PlayerId1FieldNumber"></a> PlayerId1FieldNumber

```csharp
public const int PlayerId1FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_PlayerId2FieldNumber"></a> PlayerId2FieldNumber

```csharp
public const int PlayerId2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_HasPlayerId1"></a> HasPlayerId1

```csharp
public bool HasPlayerId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_HasPlayerId2"></a> HasPlayerId2

```csharp
public bool HasPlayerId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HotPotato_Created> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HotPotato\_Created](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Created.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_PlayerId1"></a> PlayerId1

```csharp
public int PlayerId1 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_PlayerId2"></a> PlayerId2

```csharp
public int PlayerId2 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_ClearPlayerId1"></a> ClearPlayerId1\(\)

```csharp
public void ClearPlayerId1()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_ClearPlayerId2"></a> ClearPlayerId2\(\)

```csharp
public void ClearPlayerId2()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HotPotato_Created Clone()
```

#### Returns

 [CDOTAUserMsg\_HotPotato\_Created](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Created.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_"></a> Equals\(CDOTAUserMsg\_HotPotato\_Created\)

```csharp
public bool Equals(CDOTAUserMsg_HotPotato_Created other)
```

#### Parameters

`other` [CDOTAUserMsg\_HotPotato\_Created](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Created.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_"></a> MergeFrom\(CDOTAUserMsg\_HotPotato\_Created\)

```csharp
public void MergeFrom(CDOTAUserMsg_HotPotato_Created other)
```

#### Parameters

`other` [CDOTAUserMsg\_HotPotato\_Created](Divine.Protobufs.Dota2.CDOTAUserMsg\_HotPotato\_Created.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HotPotato_Created_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

