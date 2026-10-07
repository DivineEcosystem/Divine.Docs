# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart"></a> Class CDOTAUserMsg\_VoteStart

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_VoteStart : IMessage<CDOTAUserMsg_VoteStart>, IEquatable<CDOTAUserMsg_VoteStart>, IDeepCloneable<CDOTAUserMsg_VoteStart>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_VoteStart](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteStart.md)

#### Implements

IMessage<CDOTAUserMsg\_VoteStart\>, 
[IEquatable<CDOTAUserMsg\_VoteStart\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_VoteStart\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_VoteStart\>\(CDOTAUserMsg\_VoteStart, params CDOTAUserMsg\_VoteStart\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart__ctor"></a> CDOTAUserMsg\_VoteStart\(\)

```csharp
public CDOTAUserMsg_VoteStart()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_"></a> CDOTAUserMsg\_VoteStart\(CDOTAUserMsg\_VoteStart\)

```csharp
public CDOTAUserMsg_VoteStart(CDOTAUserMsg_VoteStart other)
```

#### Parameters

`other` [CDOTAUserMsg\_VoteStart](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteStart.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ChoiceCountFieldNumber"></a> ChoiceCountFieldNumber

```csharp
public const int ChoiceCountFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ChoicesFieldNumber"></a> ChoicesFieldNumber

```csharp
public const int ChoicesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_DurationFieldNumber"></a> DurationFieldNumber

```csharp
public const int DurationFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_TitleFieldNumber"></a> TitleFieldNumber

```csharp
public const int TitleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ChoiceCount"></a> ChoiceCount

```csharp
public int ChoiceCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Choices"></a> Choices

```csharp
public RepeatedField<string> Choices { get; }
```

#### Property Value

 RepeatedField<[string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Duration"></a> Duration

```csharp
public float Duration { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_HasChoiceCount"></a> HasChoiceCount

```csharp
public bool HasChoiceCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_HasDuration"></a> HasDuration

```csharp
public bool HasDuration { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_HasTitle"></a> HasTitle

```csharp
public bool HasTitle { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_VoteStart> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_VoteStart](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteStart.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Title"></a> Title

```csharp
public string Title { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ClearChoiceCount"></a> ClearChoiceCount\(\)

```csharp
public void ClearChoiceCount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ClearDuration"></a> ClearDuration\(\)

```csharp
public void ClearDuration()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ClearTitle"></a> ClearTitle\(\)

```csharp
public void ClearTitle()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_VoteStart Clone()
```

#### Returns

 [CDOTAUserMsg\_VoteStart](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteStart.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_"></a> Equals\(CDOTAUserMsg\_VoteStart\)

```csharp
public bool Equals(CDOTAUserMsg_VoteStart other)
```

#### Parameters

`other` [CDOTAUserMsg\_VoteStart](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteStart.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_"></a> MergeFrom\(CDOTAUserMsg\_VoteStart\)

```csharp
public void MergeFrom(CDOTAUserMsg_VoteStart other)
```

#### Parameters

`other` [CDOTAUserMsg\_VoteStart](Divine.Protobufs.Dota2.CDOTAUserMsg\_VoteStart.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_VoteStart_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

