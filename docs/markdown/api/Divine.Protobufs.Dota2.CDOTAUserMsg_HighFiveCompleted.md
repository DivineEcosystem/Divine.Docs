# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted"></a> Class CDOTAUserMsg\_HighFiveCompleted

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_HighFiveCompleted : IMessage<CDOTAUserMsg_HighFiveCompleted>, IEquatable<CDOTAUserMsg_HighFiveCompleted>, IDeepCloneable<CDOTAUserMsg_HighFiveCompleted>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_HighFiveCompleted](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveCompleted.md)

#### Implements

IMessage<CDOTAUserMsg\_HighFiveCompleted\>, 
[IEquatable<CDOTAUserMsg\_HighFiveCompleted\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_HighFiveCompleted\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_HighFiveCompleted\>\(CDOTAUserMsg\_HighFiveCompleted, params CDOTAUserMsg\_HighFiveCompleted\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted__ctor"></a> CDOTAUserMsg\_HighFiveCompleted\(\)

```csharp
public CDOTAUserMsg_HighFiveCompleted()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_"></a> CDOTAUserMsg\_HighFiveCompleted\(CDOTAUserMsg\_HighFiveCompleted\)

```csharp
public CDOTAUserMsg_HighFiveCompleted(CDOTAUserMsg_HighFiveCompleted other)
```

#### Parameters

`other` [CDOTAUserMsg\_HighFiveCompleted](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveCompleted.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_PlayerId1FieldNumber"></a> PlayerId1FieldNumber

```csharp
public const int PlayerId1FieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_PlayerId2FieldNumber"></a> PlayerId2FieldNumber

```csharp
public const int PlayerId2FieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_SpecialEntindexFieldNumber"></a> SpecialEntindexFieldNumber

```csharp
public const int SpecialEntindexFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_SpecialHighFiveFieldNumber"></a> SpecialHighFiveFieldNumber

```csharp
public const int SpecialHighFiveFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_HasPlayerId1"></a> HasPlayerId1

```csharp
public bool HasPlayerId1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_HasPlayerId2"></a> HasPlayerId2

```csharp
public bool HasPlayerId2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_HasSpecialEntindex"></a> HasSpecialEntindex

```csharp
public bool HasSpecialEntindex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_HasSpecialHighFive"></a> HasSpecialHighFive

```csharp
public bool HasSpecialHighFive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_HighFiveCompleted> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_HighFiveCompleted](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveCompleted.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_PlayerId1"></a> PlayerId1

```csharp
public int PlayerId1 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_PlayerId2"></a> PlayerId2

```csharp
public int PlayerId2 { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_SpecialEntindex"></a> SpecialEntindex

```csharp
public int SpecialEntindex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_SpecialHighFive"></a> SpecialHighFive

```csharp
public bool SpecialHighFive { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_ClearPlayerId1"></a> ClearPlayerId1\(\)

```csharp
public void ClearPlayerId1()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_ClearPlayerId2"></a> ClearPlayerId2\(\)

```csharp
public void ClearPlayerId2()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_ClearSpecialEntindex"></a> ClearSpecialEntindex\(\)

```csharp
public void ClearSpecialEntindex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_ClearSpecialHighFive"></a> ClearSpecialHighFive\(\)

```csharp
public void ClearSpecialHighFive()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_HighFiveCompleted Clone()
```

#### Returns

 [CDOTAUserMsg\_HighFiveCompleted](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveCompleted.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_"></a> Equals\(CDOTAUserMsg\_HighFiveCompleted\)

```csharp
public bool Equals(CDOTAUserMsg_HighFiveCompleted other)
```

#### Parameters

`other` [CDOTAUserMsg\_HighFiveCompleted](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveCompleted.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_"></a> MergeFrom\(CDOTAUserMsg\_HighFiveCompleted\)

```csharp
public void MergeFrom(CDOTAUserMsg_HighFiveCompleted other)
```

#### Parameters

`other` [CDOTAUserMsg\_HighFiveCompleted](Divine.Protobufs.Dota2.CDOTAUserMsg\_HighFiveCompleted.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_HighFiveCompleted_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

