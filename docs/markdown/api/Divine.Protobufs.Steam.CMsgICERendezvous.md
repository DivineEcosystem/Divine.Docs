# <a id="Divine_Protobufs_Steam_CMsgICERendezvous"></a> Class CMsgICERendezvous

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgICERendezvous : IMessage<CMsgICERendezvous>, IEquatable<CMsgICERendezvous>, IDeepCloneable<CMsgICERendezvous>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)

#### Implements

IMessage<CMsgICERendezvous\>, 
[IEquatable<CMsgICERendezvous\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgICERendezvous\>, 
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
[EnumerableExtensions.In<CMsgICERendezvous\>\(CMsgICERendezvous, params CMsgICERendezvous\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous__ctor"></a> CMsgICERendezvous\(\)

```csharp
public CMsgICERendezvous()
```

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous__ctor_Divine_Protobufs_Steam_CMsgICERendezvous_"></a> CMsgICERendezvous\(CMsgICERendezvous\)

```csharp
public CMsgICERendezvous(CMsgICERendezvous other)
```

#### Parameters

`other` [CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_AddCandidateFieldNumber"></a> AddCandidateFieldNumber

```csharp
public const int AddCandidateFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_AuthFieldNumber"></a> AuthFieldNumber

```csharp
public const int AuthFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_AddCandidate"></a> AddCandidate

```csharp
public CMsgICECandidate AddCandidate { get; set; }
```

#### Property Value

 [CMsgICECandidate](Divine.Protobufs.Steam.CMsgICECandidate.md)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_Auth"></a> Auth

```csharp
public CMsgICERendezvous.Types.Auth Auth { get; set; }
```

#### Property Value

 [CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md).[Types](Divine.Protobufs.Steam.CMsgICERendezvous.Types.md).[Auth](Divine.Protobufs.Steam.CMsgICERendezvous.Types.Auth.md)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_Parser"></a> Parser

```csharp
public static MessageParser<CMsgICERendezvous> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_Clone"></a> Clone\(\)

```csharp
public CMsgICERendezvous Clone()
```

#### Returns

 [CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_Equals_Divine_Protobufs_Steam_CMsgICERendezvous_"></a> Equals\(CMsgICERendezvous\)

```csharp
public bool Equals(CMsgICERendezvous other)
```

#### Parameters

`other` [CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_MergeFrom_Divine_Protobufs_Steam_CMsgICERendezvous_"></a> MergeFrom\(CMsgICERendezvous\)

```csharp
public void MergeFrom(CMsgICERendezvous other)
```

#### Parameters

`other` [CMsgICERendezvous](Divine.Protobufs.Steam.CMsgICERendezvous.md)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgICERendezvous_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

