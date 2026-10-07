# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage"></a> Class CDOTAUserMsg\_CustomHeaderMessage

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_CustomHeaderMessage : IMessage<CDOTAUserMsg_CustomHeaderMessage>, IEquatable<CDOTAUserMsg_CustomHeaderMessage>, IDeepCloneable<CDOTAUserMsg_CustomHeaderMessage>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_CustomHeaderMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHeaderMessage.md)

#### Implements

IMessage<CDOTAUserMsg\_CustomHeaderMessage\>, 
[IEquatable<CDOTAUserMsg\_CustomHeaderMessage\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_CustomHeaderMessage\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_CustomHeaderMessage\>\(CDOTAUserMsg\_CustomHeaderMessage, params CDOTAUserMsg\_CustomHeaderMessage\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage__ctor"></a> CDOTAUserMsg\_CustomHeaderMessage\(\)

```csharp
public CDOTAUserMsg_CustomHeaderMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_"></a> CDOTAUserMsg\_CustomHeaderMessage\(CDOTAUserMsg\_CustomHeaderMessage\)

```csharp
public CDOTAUserMsg_CustomHeaderMessage(CDOTAUserMsg_CustomHeaderMessage other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHeaderMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHeaderMessage.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_CustomHeaderMessage> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_CustomHeaderMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHeaderMessage.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Value"></a> Value

```csharp
public int Value { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_CustomHeaderMessage Clone()
```

#### Returns

 [CDOTAUserMsg\_CustomHeaderMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHeaderMessage.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_"></a> Equals\(CDOTAUserMsg\_CustomHeaderMessage\)

```csharp
public bool Equals(CDOTAUserMsg_CustomHeaderMessage other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHeaderMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHeaderMessage.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_"></a> MergeFrom\(CDOTAUserMsg\_CustomHeaderMessage\)

```csharp
public void MergeFrom(CDOTAUserMsg_CustomHeaderMessage other)
```

#### Parameters

`other` [CDOTAUserMsg\_CustomHeaderMessage](Divine.Protobufs.Dota2.CDOTAUserMsg\_CustomHeaderMessage.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_CustomHeaderMessage_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

