# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate"></a> Class CDOTAClientMsg\_RequestGraphUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_RequestGraphUpdate : IMessage<CDOTAClientMsg_RequestGraphUpdate>, IEquatable<CDOTAClientMsg_RequestGraphUpdate>, IDeepCloneable<CDOTAClientMsg_RequestGraphUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_RequestGraphUpdate](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestGraphUpdate.md)

#### Implements

IMessage<CDOTAClientMsg\_RequestGraphUpdate\>, 
[IEquatable<CDOTAClientMsg\_RequestGraphUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_RequestGraphUpdate\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_RequestGraphUpdate\>\(CDOTAClientMsg\_RequestGraphUpdate, params CDOTAClientMsg\_RequestGraphUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate__ctor"></a> CDOTAClientMsg\_RequestGraphUpdate\(\)

```csharp
public CDOTAClientMsg_RequestGraphUpdate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_"></a> CDOTAClientMsg\_RequestGraphUpdate\(CDOTAClientMsg\_RequestGraphUpdate\)

```csharp
public CDOTAClientMsg_RequestGraphUpdate(CDOTAClientMsg_RequestGraphUpdate other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestGraphUpdate](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestGraphUpdate.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_RequestGraphUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_RequestGraphUpdate](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestGraphUpdate.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_RequestGraphUpdate Clone()
```

#### Returns

 [CDOTAClientMsg\_RequestGraphUpdate](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestGraphUpdate.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_"></a> Equals\(CDOTAClientMsg\_RequestGraphUpdate\)

```csharp
public bool Equals(CDOTAClientMsg_RequestGraphUpdate other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestGraphUpdate](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestGraphUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_"></a> MergeFrom\(CDOTAClientMsg\_RequestGraphUpdate\)

```csharp
public void MergeFrom(CDOTAClientMsg_RequestGraphUpdate other)
```

#### Parameters

`other` [CDOTAClientMsg\_RequestGraphUpdate](Divine.Protobufs.Dota2.CDOTAClientMsg\_RequestGraphUpdate.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_RequestGraphUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

