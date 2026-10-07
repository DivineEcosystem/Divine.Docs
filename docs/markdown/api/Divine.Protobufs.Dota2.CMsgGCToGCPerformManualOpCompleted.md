# <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted"></a> Class CMsgGCToGCPerformManualOpCompleted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToGCPerformManualOpCompleted : IMessage<CMsgGCToGCPerformManualOpCompleted>, IEquatable<CMsgGCToGCPerformManualOpCompleted>, IDeepCloneable<CMsgGCToGCPerformManualOpCompleted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToGCPerformManualOpCompleted](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOpCompleted.md)

#### Implements

IMessage<CMsgGCToGCPerformManualOpCompleted\>, 
[IEquatable<CMsgGCToGCPerformManualOpCompleted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToGCPerformManualOpCompleted\>, 
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
[EnumerableExtensions.In<CMsgGCToGCPerformManualOpCompleted\>\(CMsgGCToGCPerformManualOpCompleted, params CMsgGCToGCPerformManualOpCompleted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted__ctor"></a> CMsgGCToGCPerformManualOpCompleted\(\)

```csharp
public CMsgGCToGCPerformManualOpCompleted()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted__ctor_Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_"></a> CMsgGCToGCPerformManualOpCompleted\(CMsgGCToGCPerformManualOpCompleted\)

```csharp
public CMsgGCToGCPerformManualOpCompleted(CMsgGCToGCPerformManualOpCompleted other)
```

#### Parameters

`other` [CMsgGCToGCPerformManualOpCompleted](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOpCompleted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_SourceGcFieldNumber"></a> SourceGcFieldNumber

```csharp
public const int SourceGcFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_SuccessFieldNumber"></a> SuccessFieldNumber

```csharp
public const int SuccessFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_HasSourceGc"></a> HasSourceGc

```csharp
public bool HasSourceGc { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_HasSuccess"></a> HasSuccess

```csharp
public bool HasSuccess { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToGCPerformManualOpCompleted> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToGCPerformManualOpCompleted](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOpCompleted.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_SourceGc"></a> SourceGc

```csharp
public int SourceGc { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_Success"></a> Success

```csharp
public bool Success { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_ClearSourceGc"></a> ClearSourceGc\(\)

```csharp
public void ClearSourceGc()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_ClearSuccess"></a> ClearSuccess\(\)

```csharp
public void ClearSuccess()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_Clone"></a> Clone\(\)

```csharp
public CMsgGCToGCPerformManualOpCompleted Clone()
```

#### Returns

 [CMsgGCToGCPerformManualOpCompleted](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOpCompleted.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_Equals_Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_"></a> Equals\(CMsgGCToGCPerformManualOpCompleted\)

```csharp
public bool Equals(CMsgGCToGCPerformManualOpCompleted other)
```

#### Parameters

`other` [CMsgGCToGCPerformManualOpCompleted](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOpCompleted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_"></a> MergeFrom\(CMsgGCToGCPerformManualOpCompleted\)

```csharp
public void MergeFrom(CMsgGCToGCPerformManualOpCompleted other)
```

#### Parameters

`other` [CMsgGCToGCPerformManualOpCompleted](Divine.Protobufs.Dota2.CMsgGCToGCPerformManualOpCompleted.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToGCPerformManualOpCompleted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

