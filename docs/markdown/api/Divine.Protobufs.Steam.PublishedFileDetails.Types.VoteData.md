# <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData"></a> Class PublishedFileDetails.Types.VoteData

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class PublishedFileDetails.Types.VoteData : IMessage<PublishedFileDetails.Types.VoteData>, IEquatable<PublishedFileDetails.Types.VoteData>, IDeepCloneable<PublishedFileDetails.Types.VoteData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PublishedFileDetails.Types.VoteData](Divine.Protobufs.Steam.PublishedFileDetails.Types.VoteData.md)

#### Implements

IMessage<PublishedFileDetails.Types.VoteData\>, 
[IEquatable<PublishedFileDetails.Types.VoteData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<PublishedFileDetails.Types.VoteData\>, 
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
[EnumerableExtensions.In<PublishedFileDetails.Types.VoteData\>\(PublishedFileDetails.Types.VoteData, params PublishedFileDetails.Types.VoteData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData__ctor"></a> VoteData\(\)

```csharp
public VoteData()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData__ctor_Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_"></a> VoteData\(VoteData\)

```csharp
public VoteData(PublishedFileDetails.Types.VoteData other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[VoteData](Divine.Protobufs.Steam.PublishedFileDetails.Types.VoteData.md)

## Fields

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_VotesDownFieldNumber"></a> VotesDownFieldNumber

```csharp
public const int VotesDownFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_VotesUpFieldNumber"></a> VotesUpFieldNumber

```csharp
public const int VotesUpFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_HasVotesDown"></a> HasVotesDown

```csharp
public bool HasVotesDown { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_HasVotesUp"></a> HasVotesUp

```csharp
public bool HasVotesUp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_Parser"></a> Parser

```csharp
public static MessageParser<PublishedFileDetails.Types.VoteData> Parser { get; }
```

#### Property Value

 MessageParser<[PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[VoteData](Divine.Protobufs.Steam.PublishedFileDetails.Types.VoteData.md)\>

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_Score"></a> Score

```csharp
public float Score { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_VotesDown"></a> VotesDown

```csharp
public uint VotesDown { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_VotesUp"></a> VotesUp

```csharp
public uint VotesUp { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_ClearVotesDown"></a> ClearVotesDown\(\)

```csharp
public void ClearVotesDown()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_ClearVotesUp"></a> ClearVotesUp\(\)

```csharp
public void ClearVotesUp()
```

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_Clone"></a> Clone\(\)

```csharp
public PublishedFileDetails.Types.VoteData Clone()
```

#### Returns

 [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[VoteData](Divine.Protobufs.Steam.PublishedFileDetails.Types.VoteData.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_Equals_Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_"></a> Equals\(VoteData\)

```csharp
public bool Equals(PublishedFileDetails.Types.VoteData other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[VoteData](Divine.Protobufs.Steam.PublishedFileDetails.Types.VoteData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_MergeFrom_Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_"></a> MergeFrom\(VoteData\)

```csharp
public void MergeFrom(PublishedFileDetails.Types.VoteData other)
```

#### Parameters

`other` [PublishedFileDetails](Divine.Protobufs.Steam.PublishedFileDetails.md).[Types](Divine.Protobufs.Steam.PublishedFileDetails.Types.md).[VoteData](Divine.Protobufs.Steam.PublishedFileDetails.Types.VoteData.md)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_PublishedFileDetails_Types_VoteData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

