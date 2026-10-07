# <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState"></a> Class CSODOTAMapLocationState

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAMapLocationState : IMessage<CSODOTAMapLocationState>, IEquatable<CSODOTAMapLocationState>, IDeepCloneable<CSODOTAMapLocationState>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAMapLocationState](Divine.Protobufs.Dota2.CSODOTAMapLocationState.md)

#### Implements

IMessage<CSODOTAMapLocationState\>, 
[IEquatable<CSODOTAMapLocationState\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAMapLocationState\>, 
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
[EnumerableExtensions.In<CSODOTAMapLocationState\>\(CSODOTAMapLocationState, params CSODOTAMapLocationState\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState__ctor"></a> CSODOTAMapLocationState\(\)

```csharp
public CSODOTAMapLocationState()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState__ctor_Divine_Protobufs_Dota2_CSODOTAMapLocationState_"></a> CSODOTAMapLocationState\(CSODOTAMapLocationState\)

```csharp
public CSODOTAMapLocationState(CSODOTAMapLocationState other)
```

#### Parameters

`other` [CSODOTAMapLocationState](Divine.Protobufs.Dota2.CSODOTAMapLocationState.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_CompletedFieldNumber"></a> CompletedFieldNumber

```csharp
public const int CompletedFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_LocationIdFieldNumber"></a> LocationIdFieldNumber

```csharp
public const int LocationIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_Completed"></a> Completed

```csharp
public bool Completed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_HasCompleted"></a> HasCompleted

```csharp
public bool HasCompleted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_HasLocationId"></a> HasLocationId

```csharp
public bool HasLocationId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_LocationId"></a> LocationId

```csharp
public int LocationId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAMapLocationState> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAMapLocationState](Divine.Protobufs.Dota2.CSODOTAMapLocationState.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_ClearCompleted"></a> ClearCompleted\(\)

```csharp
public void ClearCompleted()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_ClearLocationId"></a> ClearLocationId\(\)

```csharp
public void ClearLocationId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_Clone"></a> Clone\(\)

```csharp
public CSODOTAMapLocationState Clone()
```

#### Returns

 [CSODOTAMapLocationState](Divine.Protobufs.Dota2.CSODOTAMapLocationState.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_Equals_Divine_Protobufs_Dota2_CSODOTAMapLocationState_"></a> Equals\(CSODOTAMapLocationState\)

```csharp
public bool Equals(CSODOTAMapLocationState other)
```

#### Parameters

`other` [CSODOTAMapLocationState](Divine.Protobufs.Dota2.CSODOTAMapLocationState.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_MergeFrom_Divine_Protobufs_Dota2_CSODOTAMapLocationState_"></a> MergeFrom\(CSODOTAMapLocationState\)

```csharp
public void MergeFrom(CSODOTAMapLocationState other)
```

#### Parameters

`other` [CSODOTAMapLocationState](Divine.Protobufs.Dota2.CSODOTAMapLocationState.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAMapLocationState_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

