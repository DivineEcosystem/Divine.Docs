# <a id="Divine_Protobufs_Steam_CMsgICECandidate"></a> Class CMsgICECandidate

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgICECandidate : IMessage<CMsgICECandidate>, IEquatable<CMsgICECandidate>, IDeepCloneable<CMsgICECandidate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)

#### Implements

IMessage<CMsgICECandidate\>, 
[IEquatable<CMsgICECandidate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgICECandidate\>, 
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
[EnumerableExtensions.In<CMsgICECandidate\>\(CMsgICECandidate, params CMsgICECandidate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgICECandidate__ctor"></a> CMsgICECandidate\(\)

```csharp
public CMsgICECandidate()
```

### <a id="Divine_Protobufs_Steam_CMsgICECandidate__ctor_Divine_Protobufs_Steam_CMsgICECandidate_"></a> CMsgICECandidate\(CMsgICECandidate\)

```csharp
public CMsgICECandidate(CMsgICECandidate other)
```

#### Parameters

`other` [CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_CandidateFieldNumber"></a> CandidateFieldNumber

```csharp
public const int CandidateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_Candidate"></a> Candidate

```csharp
public string Candidate { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_HasCandidate"></a> HasCandidate

```csharp
public bool HasCandidate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgICECandidate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_ClearCandidate"></a> ClearCandidate\(\)

```csharp
public void ClearCandidate()
```

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_Clone"></a> Clone\(\)

```csharp
public CMsgICECandidate Clone()
```

#### Returns

 [CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_Equals_Divine_Protobufs_Steam_CMsgICECandidate_"></a> Equals\(CMsgICECandidate\)

```csharp
public bool Equals(CMsgICECandidate other)
```

#### Parameters

`other` [CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_MergeFrom_Divine_Protobufs_Steam_CMsgICECandidate_"></a> MergeFrom\(CMsgICECandidate\)

```csharp
public void MergeFrom(CMsgICECandidate other)
```

#### Parameters

`other` [CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgICECandidate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

