# <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData"></a> Class CMsgDOTARealtimeGameStatsTerse.Types.GraphData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTARealtimeGameStatsTerse.Types.GraphData : IMessage<CMsgDOTARealtimeGameStatsTerse.Types.GraphData>, IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.GraphData>, IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.GraphData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTARealtimeGameStatsTerse.Types.GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)

#### Implements

IMessage<CMsgDOTARealtimeGameStatsTerse.Types.GraphData\>, 
[IEquatable<CMsgDOTARealtimeGameStatsTerse.Types.GraphData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTARealtimeGameStatsTerse.Types.GraphData\>, 
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
[EnumerableExtensions.In<CMsgDOTARealtimeGameStatsTerse.Types.GraphData\>\(CMsgDOTARealtimeGameStatsTerse.Types.GraphData, params CMsgDOTARealtimeGameStatsTerse.Types.GraphData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData__ctor"></a> GraphData\(\)

```csharp
public GraphData()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData__ctor_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_"></a> GraphData\(GraphData\)

```csharp
public GraphData(CMsgDOTARealtimeGameStatsTerse.Types.GraphData other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_GraphGoldFieldNumber"></a> GraphGoldFieldNumber

```csharp
public const int GraphGoldFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_GraphGold"></a> GraphGold

```csharp
public RepeatedField<int> GraphGold { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTARealtimeGameStatsTerse.Types.GraphData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_Clone"></a> Clone\(\)

```csharp
public CMsgDOTARealtimeGameStatsTerse.Types.GraphData Clone()
```

#### Returns

 [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_Equals_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_"></a> Equals\(GraphData\)

```csharp
public bool Equals(CMsgDOTARealtimeGameStatsTerse.Types.GraphData other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_"></a> MergeFrom\(GraphData\)

```csharp
public void MergeFrom(CMsgDOTARealtimeGameStatsTerse.Types.GraphData other)
```

#### Parameters

`other` [CMsgDOTARealtimeGameStatsTerse](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.md).[GraphData](Divine.Protobufs.Dota2.CMsgDOTARealtimeGameStatsTerse.Types.GraphData.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTARealtimeGameStatsTerse_Types_GraphData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

