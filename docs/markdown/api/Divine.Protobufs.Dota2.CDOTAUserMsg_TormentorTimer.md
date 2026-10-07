# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer"></a> Class CDOTAUserMsg\_TormentorTimer

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_TormentorTimer : IMessage<CDOTAUserMsg_TormentorTimer>, IEquatable<CDOTAUserMsg_TormentorTimer>, IDeepCloneable<CDOTAUserMsg_TormentorTimer>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_TormentorTimer](Divine.Protobufs.Dota2.CDOTAUserMsg\_TormentorTimer.md)

#### Implements

IMessage<CDOTAUserMsg\_TormentorTimer\>, 
[IEquatable<CDOTAUserMsg\_TormentorTimer\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_TormentorTimer\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_TormentorTimer\>\(CDOTAUserMsg\_TormentorTimer, params CDOTAUserMsg\_TormentorTimer\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer__ctor"></a> CDOTAUserMsg\_TormentorTimer\(\)

```csharp
public CDOTAUserMsg_TormentorTimer()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_"></a> CDOTAUserMsg\_TormentorTimer\(CDOTAUserMsg\_TormentorTimer\)

```csharp
public CDOTAUserMsg_TormentorTimer(CDOTAUserMsg_TormentorTimer other)
```

#### Parameters

`other` [CDOTAUserMsg\_TormentorTimer](Divine.Protobufs.Dota2.CDOTAUserMsg\_TormentorTimer.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_NegativeFieldNumber"></a> NegativeFieldNumber

```csharp
public const int NegativeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_HasNegative"></a> HasNegative

```csharp
public bool HasNegative { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_Negative"></a> Negative

```csharp
public bool Negative { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_TormentorTimer> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_TormentorTimer](Divine.Protobufs.Dota2.CDOTAUserMsg\_TormentorTimer.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_ClearNegative"></a> ClearNegative\(\)

```csharp
public void ClearNegative()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_TormentorTimer Clone()
```

#### Returns

 [CDOTAUserMsg\_TormentorTimer](Divine.Protobufs.Dota2.CDOTAUserMsg\_TormentorTimer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_"></a> Equals\(CDOTAUserMsg\_TormentorTimer\)

```csharp
public bool Equals(CDOTAUserMsg_TormentorTimer other)
```

#### Parameters

`other` [CDOTAUserMsg\_TormentorTimer](Divine.Protobufs.Dota2.CDOTAUserMsg\_TormentorTimer.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_"></a> MergeFrom\(CDOTAUserMsg\_TormentorTimer\)

```csharp
public void MergeFrom(CDOTAUserMsg_TormentorTimer other)
```

#### Parameters

`other` [CDOTAUserMsg\_TormentorTimer](Divine.Protobufs.Dota2.CDOTAUserMsg\_TormentorTimer.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_TormentorTimer_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

