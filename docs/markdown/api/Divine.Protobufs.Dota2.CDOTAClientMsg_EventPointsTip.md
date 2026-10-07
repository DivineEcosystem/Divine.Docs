# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip"></a> Class CDOTAClientMsg\_EventPointsTip

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_EventPointsTip : IMessage<CDOTAClientMsg_EventPointsTip>, IEquatable<CDOTAClientMsg_EventPointsTip>, IDeepCloneable<CDOTAClientMsg_EventPointsTip>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_EventPointsTip](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventPointsTip.md)

#### Implements

IMessage<CDOTAClientMsg\_EventPointsTip\>, 
[IEquatable<CDOTAClientMsg\_EventPointsTip\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_EventPointsTip\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_EventPointsTip\>\(CDOTAClientMsg\_EventPointsTip, params CDOTAClientMsg\_EventPointsTip\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip__ctor"></a> CDOTAClientMsg\_EventPointsTip\(\)

```csharp
public CDOTAClientMsg_EventPointsTip()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_"></a> CDOTAClientMsg\_EventPointsTip\(CDOTAClientMsg\_EventPointsTip\)

```csharp
public CDOTAClientMsg_EventPointsTip(CDOTAClientMsg_EventPointsTip other)
```

#### Parameters

`other` [CDOTAClientMsg\_EventPointsTip](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventPointsTip.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_RecipientPlayerIdFieldNumber"></a> RecipientPlayerIdFieldNumber

```csharp
public const int RecipientPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_HasRecipientPlayerId"></a> HasRecipientPlayerId

```csharp
public bool HasRecipientPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_EventPointsTip> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_EventPointsTip](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventPointsTip.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_RecipientPlayerId"></a> RecipientPlayerId

```csharp
public int RecipientPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_ClearRecipientPlayerId"></a> ClearRecipientPlayerId\(\)

```csharp
public void ClearRecipientPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_EventPointsTip Clone()
```

#### Returns

 [CDOTAClientMsg\_EventPointsTip](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventPointsTip.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_"></a> Equals\(CDOTAClientMsg\_EventPointsTip\)

```csharp
public bool Equals(CDOTAClientMsg_EventPointsTip other)
```

#### Parameters

`other` [CDOTAClientMsg\_EventPointsTip](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventPointsTip.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_"></a> MergeFrom\(CDOTAClientMsg\_EventPointsTip\)

```csharp
public void MergeFrom(CDOTAClientMsg_EventPointsTip other)
```

#### Parameters

`other` [CDOTAClientMsg\_EventPointsTip](Divine.Protobufs.Dota2.CDOTAClientMsg\_EventPointsTip.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_EventPointsTip_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

