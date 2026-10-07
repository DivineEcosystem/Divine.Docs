# <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState"></a> Class CUserMessageAnimStateGraphState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageAnimStateGraphState : IMessage<CUserMessageAnimStateGraphState>, IEquatable<CUserMessageAnimStateGraphState>, IDeepCloneable<CUserMessageAnimStateGraphState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageAnimStateGraphState](Divine.Protobufs.Dota2.CUserMessageAnimStateGraphState.md)

#### Implements

IMessage<CUserMessageAnimStateGraphState\>, 
[IEquatable<CUserMessageAnimStateGraphState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageAnimStateGraphState\>, 
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
[EnumerableExtensions.In<CUserMessageAnimStateGraphState\>\(CUserMessageAnimStateGraphState, params CUserMessageAnimStateGraphState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState__ctor"></a> CUserMessageAnimStateGraphState\(\)

```csharp
public CUserMessageAnimStateGraphState()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState__ctor_Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_"></a> CUserMessageAnimStateGraphState\(CUserMessageAnimStateGraphState\)

```csharp
public CUserMessageAnimStateGraphState(CUserMessageAnimStateGraphState other)
```

#### Parameters

`other` [CUserMessageAnimStateGraphState](Divine.Protobufs.Dota2.CUserMessageAnimStateGraphState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_EntityIndexFieldNumber"></a> EntityIndexFieldNumber

```csharp
public const int EntityIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_Data"></a> Data

```csharp
public ByteString Data { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_EntityIndex"></a> EntityIndex

```csharp
public int EntityIndex { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_HasEntityIndex"></a> HasEntityIndex

```csharp
public bool HasEntityIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageAnimStateGraphState> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageAnimStateGraphState](Divine.Protobufs.Dota2.CUserMessageAnimStateGraphState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_ClearEntityIndex"></a> ClearEntityIndex\(\)

```csharp
public void ClearEntityIndex()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_Clone"></a> Clone\(\)

```csharp
public CUserMessageAnimStateGraphState Clone()
```

#### Returns

 [CUserMessageAnimStateGraphState](Divine.Protobufs.Dota2.CUserMessageAnimStateGraphState.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_Equals_Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_"></a> Equals\(CUserMessageAnimStateGraphState\)

```csharp
public bool Equals(CUserMessageAnimStateGraphState other)
```

#### Parameters

`other` [CUserMessageAnimStateGraphState](Divine.Protobufs.Dota2.CUserMessageAnimStateGraphState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_MergeFrom_Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_"></a> MergeFrom\(CUserMessageAnimStateGraphState\)

```csharp
public void MergeFrom(CUserMessageAnimStateGraphState other)
```

#### Parameters

`other` [CUserMessageAnimStateGraphState](Divine.Protobufs.Dota2.CUserMessageAnimStateGraphState.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageAnimStateGraphState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

