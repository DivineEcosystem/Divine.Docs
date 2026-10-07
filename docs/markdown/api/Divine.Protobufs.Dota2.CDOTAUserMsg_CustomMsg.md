# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg"></a> Class CDOTAUserMsg\_CustomMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CustomMsg : IMessage<CDOTAUserMsg_CustomMsg>, IEquatable<CDOTAUserMsg_CustomMsg>, IDeepCloneable<CDOTAUserMsg_CustomMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CustomMsg](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomMsg.md)

#### Implements

IMessage<CDOTAUserMsg\_CustomMsg\>, 
[IEquatable<CDOTAUserMsg\_CustomMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CustomMsg\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CustomMsg\>\(CDOTAUserMsg\_CustomMsg, params CDOTAUserMsg\_CustomMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg__ctor"></a> CDOTAUserMsg\_CustomMsg\(\)

```csharp
public CDOTAUserMsg_CustomMsg()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_"></a> CDOTAUserMsg\_CustomMsg\(CDOTAUserMsg\_CustomMsg\)

```csharp
public CDOTAUserMsg_CustomMsg(CDOTAUserMsg_CustomMsg other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomMsg](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CustomMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CustomMsg](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Value"></a> Value

```csharp
public int Value { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CustomMsg Clone()
```

#### Returns

 [CDOTAUserMsg\_CustomMsg](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomMsg.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_"></a> Equals\(CDOTAUserMsg\_CustomMsg\)

```csharp
public bool Equals(CDOTAUserMsg_CustomMsg other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomMsg](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_"></a> MergeFrom\(CDOTAUserMsg\_CustomMsg\)

```csharp
public void MergeFrom(CDOTAUserMsg_CustomMsg other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomMsg](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomMsg.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

