# <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient"></a> Class CDOTASpeechMatchOnClient

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTASpeechMatchOnClient : IMessage<CDOTASpeechMatchOnClient>, IEquatable<CDOTASpeechMatchOnClient>, IDeepCloneable<CDOTASpeechMatchOnClient>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)

#### Implements

IMessage<CDOTASpeechMatchOnClient\>, 
[IEquatable<CDOTASpeechMatchOnClient\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTASpeechMatchOnClient\>, 
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
[EnumerableExtensions.In<CDOTASpeechMatchOnClient\>\(CDOTASpeechMatchOnClient, params CDOTASpeechMatchOnClient\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient__ctor"></a> CDOTASpeechMatchOnClient\(\)

```csharp
public CDOTASpeechMatchOnClient()
```

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient__ctor_Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_"></a> CDOTASpeechMatchOnClient\(CDOTASpeechMatchOnClient\)

```csharp
public CDOTASpeechMatchOnClient(CDOTASpeechMatchOnClient other)
```

#### Parameters

`other` [CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_RandomseedFieldNumber"></a> RandomseedFieldNumber

```csharp
public const int RandomseedFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_RecipientTypeFieldNumber"></a> RecipientTypeFieldNumber

```csharp
public const int RecipientTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_ResponsequeryFieldNumber"></a> ResponsequeryFieldNumber

```csharp
public const int ResponsequeryFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_SpeechConceptFieldNumber"></a> SpeechConceptFieldNumber

```csharp
public const int SpeechConceptFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_HasRandomseed"></a> HasRandomseed

```csharp
public bool HasRandomseed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_HasRecipientType"></a> HasRecipientType

```csharp
public bool HasRecipientType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_HasSpeechConcept"></a> HasSpeechConcept

```csharp
public bool HasSpeechConcept { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Parser"></a> Parser

```csharp
public static MessageParser<CDOTASpeechMatchOnClient> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Randomseed"></a> Randomseed

```csharp
public int Randomseed { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_RecipientType"></a> RecipientType

```csharp
public int RecipientType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Responsequery"></a> Responsequery

```csharp
public CDOTAResponseQuerySerialized Responsequery { get; set; }
```

#### Property Value

 [CDOTAResponseQuerySerialized](Divine.Protobufs.Dota2.CDOTAResponseQuerySerialized.md)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_SpeechConcept"></a> SpeechConcept

```csharp
public int SpeechConcept { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_ClearRandomseed"></a> ClearRandomseed\(\)

```csharp
public void ClearRandomseed()
```

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_ClearRecipientType"></a> ClearRecipientType\(\)

```csharp
public void ClearRecipientType()
```

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_ClearSpeechConcept"></a> ClearSpeechConcept\(\)

```csharp
public void ClearSpeechConcept()
```

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Clone"></a> Clone\(\)

```csharp
public CDOTASpeechMatchOnClient Clone()
```

#### Returns

 [CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_Equals_Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_"></a> Equals\(CDOTASpeechMatchOnClient\)

```csharp
public bool Equals(CDOTASpeechMatchOnClient other)
```

#### Parameters

`other` [CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_MergeFrom_Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_"></a> MergeFrom\(CDOTASpeechMatchOnClient\)

```csharp
public void MergeFrom(CDOTASpeechMatchOnClient other)
```

#### Parameters

`other` [CDOTASpeechMatchOnClient](Divine.Protobufs.Dota2.CDOTASpeechMatchOnClient.md)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTASpeechMatchOnClient_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

