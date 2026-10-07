# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus"></a> Class CMsgGCToClientPlaytestStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPlaytestStatus : IMessage<CMsgGCToClientPlaytestStatus>, IEquatable<CMsgGCToClientPlaytestStatus>, IDeepCloneable<CMsgGCToClientPlaytestStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPlaytestStatus](Divine.Protobufs.Dota2.CMsgGCToClientPlaytestStatus.md)

#### Implements

IMessage<CMsgGCToClientPlaytestStatus\>, 
[IEquatable<CMsgGCToClientPlaytestStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPlaytestStatus\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPlaytestStatus\>\(CMsgGCToClientPlaytestStatus, params CMsgGCToClientPlaytestStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus__ctor"></a> CMsgGCToClientPlaytestStatus\(\)

```csharp
public CMsgGCToClientPlaytestStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_"></a> CMsgGCToClientPlaytestStatus\(CMsgGCToClientPlaytestStatus\)

```csharp
public CMsgGCToClientPlaytestStatus(CMsgGCToClientPlaytestStatus other)
```

#### Parameters

`other` [CMsgGCToClientPlaytestStatus](Divine.Protobufs.Dota2.CMsgGCToClientPlaytestStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_ActiveFieldNumber"></a> ActiveFieldNumber

```csharp
public const int ActiveFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_Active"></a> Active

```csharp
public bool Active { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_HasActive"></a> HasActive

```csharp
public bool HasActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPlaytestStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPlaytestStatus](Divine.Protobufs.Dota2.CMsgGCToClientPlaytestStatus.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_ClearActive"></a> ClearActive\(\)

```csharp
public void ClearActive()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPlaytestStatus Clone()
```

#### Returns

 [CMsgGCToClientPlaytestStatus](Divine.Protobufs.Dota2.CMsgGCToClientPlaytestStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_"></a> Equals\(CMsgGCToClientPlaytestStatus\)

```csharp
public bool Equals(CMsgGCToClientPlaytestStatus other)
```

#### Parameters

`other` [CMsgGCToClientPlaytestStatus](Divine.Protobufs.Dota2.CMsgGCToClientPlaytestStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_"></a> MergeFrom\(CMsgGCToClientPlaytestStatus\)

```csharp
public void MergeFrom(CMsgGCToClientPlaytestStatus other)
```

#### Parameters

`other` [CMsgGCToClientPlaytestStatus](Divine.Protobufs.Dota2.CMsgGCToClientPlaytestStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPlaytestStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

