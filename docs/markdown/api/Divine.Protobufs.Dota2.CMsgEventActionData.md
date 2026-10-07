# <a id="Divine_Protobufs_Dota2_CMsgEventActionData"></a> Class CMsgEventActionData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventActionData : IMessage<CMsgEventActionData>, IEquatable<CMsgEventActionData>, IDeepCloneable<CMsgEventActionData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventActionData](Divine.Protobufs.Dota2.CMsgEventActionData.md)

#### Implements

IMessage<CMsgEventActionData\>, 
[IEquatable<CMsgEventActionData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventActionData\>, 
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
[EnumerableExtensions.In<CMsgEventActionData\>\(CMsgEventActionData, params CMsgEventActionData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData__ctor"></a> CMsgEventActionData\(\)

```csharp
public CMsgEventActionData()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData__ctor_Divine_Protobufs_Dota2_CMsgEventActionData_"></a> CMsgEventActionData\(CMsgEventActionData\)

```csharp
public CMsgEventActionData(CMsgEventActionData other)
```

#### Parameters

`other` [CMsgEventActionData](Divine.Protobufs.Dota2.CMsgEventActionData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ActionIdFieldNumber"></a> ActionIdFieldNumber

```csharp
public const int ActionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ActionScoreFieldNumber"></a> ActionScoreFieldNumber

```csharp
public const int ActionScoreFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ActionId"></a> ActionId

```csharp
public uint ActionId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ActionScore"></a> ActionScore

```csharp
public uint ActionScore { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_HasActionId"></a> HasActionId

```csharp
public bool HasActionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_HasActionScore"></a> HasActionScore

```csharp
public bool HasActionScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventActionData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventActionData](Divine.Protobufs.Dota2.CMsgEventActionData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ClearActionId"></a> ClearActionId\(\)

```csharp
public void ClearActionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ClearActionScore"></a> ClearActionScore\(\)

```csharp
public void ClearActionScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_Clone"></a> Clone\(\)

```csharp
public CMsgEventActionData Clone()
```

#### Returns

 [CMsgEventActionData](Divine.Protobufs.Dota2.CMsgEventActionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_Equals_Divine_Protobufs_Dota2_CMsgEventActionData_"></a> Equals\(CMsgEventActionData\)

```csharp
public bool Equals(CMsgEventActionData other)
```

#### Parameters

`other` [CMsgEventActionData](Divine.Protobufs.Dota2.CMsgEventActionData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_MergeFrom_Divine_Protobufs_Dota2_CMsgEventActionData_"></a> MergeFrom\(CMsgEventActionData\)

```csharp
public void MergeFrom(CMsgEventActionData other)
```

#### Parameters

`other` [CMsgEventActionData](Divine.Protobufs.Dota2.CMsgEventActionData.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventActionData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

