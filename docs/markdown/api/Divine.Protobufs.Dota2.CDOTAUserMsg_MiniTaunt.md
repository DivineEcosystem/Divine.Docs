# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt"></a> Class CDOTAUserMsg\_MiniTaunt

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MiniTaunt : IMessage<CDOTAUserMsg_MiniTaunt>, IEquatable<CDOTAUserMsg_MiniTaunt>, IDeepCloneable<CDOTAUserMsg_MiniTaunt>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MiniTaunt](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniTaunt.md)

#### Implements

IMessage<CDOTAUserMsg\_MiniTaunt\>, 
[IEquatable<CDOTAUserMsg\_MiniTaunt\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MiniTaunt\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MiniTaunt\>\(CDOTAUserMsg\_MiniTaunt, params CDOTAUserMsg\_MiniTaunt\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt__ctor"></a> CDOTAUserMsg\_MiniTaunt\(\)

```csharp
public CDOTAUserMsg_MiniTaunt()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_"></a> CDOTAUserMsg\_MiniTaunt\(CDOTAUserMsg\_MiniTaunt\)

```csharp
public CDOTAUserMsg_MiniTaunt(CDOTAUserMsg_MiniTaunt other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniTaunt](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniTaunt.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_TauntingPlayerIdFieldNumber"></a> TauntingPlayerIdFieldNumber

```csharp
public const int TauntingPlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_HasTauntingPlayerId"></a> HasTauntingPlayerId

```csharp
public bool HasTauntingPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MiniTaunt> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MiniTaunt](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniTaunt.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_TauntingPlayerId"></a> TauntingPlayerId

```csharp
public int TauntingPlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_ClearTauntingPlayerId"></a> ClearTauntingPlayerId\(\)

```csharp
public void ClearTauntingPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MiniTaunt Clone()
```

#### Returns

 [CDOTAUserMsg\_MiniTaunt](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniTaunt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_"></a> Equals\(CDOTAUserMsg\_MiniTaunt\)

```csharp
public bool Equals(CDOTAUserMsg_MiniTaunt other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniTaunt](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniTaunt.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_"></a> MergeFrom\(CDOTAUserMsg\_MiniTaunt\)

```csharp
public void MergeFrom(CDOTAUserMsg_MiniTaunt other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniTaunt](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniTaunt.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniTaunt_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

