# <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData"></a> Class CSource2Metrics\_FetchMapData\_Response.Types.MapData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSource2Metrics_FetchMapData_Response.Types.MapData : IMessage<CSource2Metrics_FetchMapData_Response.Types.MapData>, IEquatable<CSource2Metrics_FetchMapData_Response.Types.MapData>, IDeepCloneable<CSource2Metrics_FetchMapData_Response.Types.MapData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSource2Metrics\_FetchMapData\_Response.Types.MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)

#### Implements

IMessage<CSource2Metrics\_FetchMapData\_Response.Types.MapData\>, 
[IEquatable<CSource2Metrics\_FetchMapData\_Response.Types.MapData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSource2Metrics\_FetchMapData\_Response.Types.MapData\>, 
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
[EnumerableExtensions.In<CSource2Metrics\_FetchMapData\_Response.Types.MapData\>\(CSource2Metrics\_FetchMapData\_Response.Types.MapData, params CSource2Metrics\_FetchMapData\_Response.Types.MapData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData__ctor"></a> MapData\(\)

```csharp
public MapData()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData__ctor_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_"></a> MapData\(MapData\)

```csharp
public MapData(CSource2Metrics_FetchMapData_Response.Types.MapData other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.md).[MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_DataFieldNumber"></a> DataFieldNumber

```csharp
public const int DataFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_TypeFieldNumber"></a> TypeFieldNumber

```csharp
public const int TypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Data"></a> Data

```csharp
public string Data { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_HasData"></a> HasData

```csharp
public bool HasData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_HasType"></a> HasType

```csharp
public bool HasType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Parser"></a> Parser

```csharp
public static MessageParser<CSource2Metrics_FetchMapData_Response.Types.MapData> Parser { get; }
```

#### Property Value

 MessageParser<[CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.md).[MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Type"></a> Type

```csharp
public string Type { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_ClearData"></a> ClearData\(\)

```csharp
public void ClearData()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_ClearType"></a> ClearType\(\)

```csharp
public void ClearType()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Clone"></a> Clone\(\)

```csharp
public CSource2Metrics_FetchMapData_Response.Types.MapData Clone()
```

#### Returns

 [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.md).[MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_Equals_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_"></a> Equals\(MapData\)

```csharp
public bool Equals(CSource2Metrics_FetchMapData_Response.Types.MapData other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.md).[MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_MergeFrom_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_"></a> MergeFrom\(MapData\)

```csharp
public void MergeFrom(CSource2Metrics_FetchMapData_Response.Types.MapData other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.md).[MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Types_MapData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

