# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest"></a> Class CDOTAClientMsg\_SwapRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SwapRequest : IMessage<CDOTAClientMsg_SwapRequest>, IEquatable<CDOTAClientMsg_SwapRequest>, IDeepCloneable<CDOTAClientMsg_SwapRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SwapRequest](Divine.Protobufs.Dota2.CDOTAClientMsg\_SwapRequest.md)

#### Implements

IMessage<CDOTAClientMsg\_SwapRequest\>, 
[IEquatable<CDOTAClientMsg\_SwapRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SwapRequest\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SwapRequest\>\(CDOTAClientMsg\_SwapRequest, params CDOTAClientMsg\_SwapRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest__ctor"></a> CDOTAClientMsg\_SwapRequest\(\)

```csharp
public CDOTAClientMsg_SwapRequest()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_"></a> CDOTAClientMsg\_SwapRequest\(CDOTAClientMsg\_SwapRequest\)

```csharp
public CDOTAClientMsg_SwapRequest(CDOTAClientMsg_SwapRequest other)
```

#### Parameters

`other` [CDOTAClientMsg\_SwapRequest](Divine.Protobufs.Dota2.CDOTAClientMsg\_SwapRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SwapRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SwapRequest](Divine.Protobufs.Dota2.CDOTAClientMsg\_SwapRequest.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SwapRequest Clone()
```

#### Returns

 [CDOTAClientMsg\_SwapRequest](Divine.Protobufs.Dota2.CDOTAClientMsg\_SwapRequest.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_"></a> Equals\(CDOTAClientMsg\_SwapRequest\)

```csharp
public bool Equals(CDOTAClientMsg_SwapRequest other)
```

#### Parameters

`other` [CDOTAClientMsg\_SwapRequest](Divine.Protobufs.Dota2.CDOTAClientMsg\_SwapRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_"></a> MergeFrom\(CDOTAClientMsg\_SwapRequest\)

```csharp
public void MergeFrom(CDOTAClientMsg_SwapRequest other)
```

#### Parameters

`other` [CDOTAClientMsg\_SwapRequest](Divine.Protobufs.Dota2.CDOTAClientMsg\_SwapRequest.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SwapRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

