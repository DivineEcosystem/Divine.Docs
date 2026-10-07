# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested"></a> Class CDOTAUserMsg\_DuelRequested

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_DuelRequested : IMessage<CDOTAUserMsg_DuelRequested>, IEquatable<CDOTAUserMsg_DuelRequested>, IDeepCloneable<CDOTAUserMsg_DuelRequested>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_DuelRequested](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelRequested.md)

#### Implements

IMessage<CDOTAUserMsg\_DuelRequested\>, 
[IEquatable<CDOTAUserMsg\_DuelRequested\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_DuelRequested\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_DuelRequested\>\(CDOTAUserMsg\_DuelRequested, params CDOTAUserMsg\_DuelRequested\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested__ctor"></a> CDOTAUserMsg\_DuelRequested\(\)

```csharp
public CDOTAUserMsg_DuelRequested()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_"></a> CDOTAUserMsg\_DuelRequested\(CDOTAUserMsg\_DuelRequested\)

```csharp
public CDOTAUserMsg_DuelRequested(CDOTAUserMsg_DuelRequested other)
```

#### Parameters

`other` [CDOTAUserMsg\_DuelRequested](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelRequested.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_PlayerIdRequestorFieldNumber"></a> PlayerIdRequestorFieldNumber

```csharp
public const int PlayerIdRequestorFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_HasPlayerIdRequestor"></a> HasPlayerIdRequestor

```csharp
public bool HasPlayerIdRequestor { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_DuelRequested> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_DuelRequested](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelRequested.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_PlayerIdRequestor"></a> PlayerIdRequestor

```csharp
public int PlayerIdRequestor { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_ClearPlayerIdRequestor"></a> ClearPlayerIdRequestor\(\)

```csharp
public void ClearPlayerIdRequestor()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_DuelRequested Clone()
```

#### Returns

 [CDOTAUserMsg\_DuelRequested](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelRequested.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_"></a> Equals\(CDOTAUserMsg\_DuelRequested\)

```csharp
public bool Equals(CDOTAUserMsg_DuelRequested other)
```

#### Parameters

`other` [CDOTAUserMsg\_DuelRequested](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelRequested.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_"></a> MergeFrom\(CDOTAUserMsg\_DuelRequested\)

```csharp
public void MergeFrom(CDOTAUserMsg_DuelRequested other)
```

#### Parameters

`other` [CDOTAUserMsg\_DuelRequested](Divine.Protobufs.Dota2.CDOTAUserMsg\_DuelRequested.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_DuelRequested_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

