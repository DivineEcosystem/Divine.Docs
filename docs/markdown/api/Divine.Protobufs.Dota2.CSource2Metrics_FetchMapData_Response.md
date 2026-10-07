# <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response"></a> Class CSource2Metrics\_FetchMapData\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSource2Metrics_FetchMapData_Response : IMessage<CSource2Metrics_FetchMapData_Response>, IEquatable<CSource2Metrics_FetchMapData_Response>, IDeepCloneable<CSource2Metrics_FetchMapData_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md)

#### Implements

IMessage<CSource2Metrics\_FetchMapData\_Response\>, 
[IEquatable<CSource2Metrics\_FetchMapData\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSource2Metrics\_FetchMapData\_Response\>, 
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
[EnumerableExtensions.In<CSource2Metrics\_FetchMapData\_Response\>\(CSource2Metrics\_FetchMapData\_Response, params CSource2Metrics\_FetchMapData\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response__ctor"></a> CSource2Metrics\_FetchMapData\_Response\(\)

```csharp
public CSource2Metrics_FetchMapData_Response()
```

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response__ctor_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_"></a> CSource2Metrics\_FetchMapData\_Response\(CSource2Metrics\_FetchMapData\_Response\)

```csharp
public CSource2Metrics_FetchMapData_Response(CSource2Metrics_FetchMapData_Response other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_ResultsFieldNumber"></a> ResultsFieldNumber

```csharp
public const int ResultsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Parser"></a> Parser

```csharp
public static MessageParser<CSource2Metrics_FetchMapData_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md)\>

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Results"></a> Results

```csharp
public RepeatedField<CSource2Metrics_FetchMapData_Response.Types.MapData> Results { get; }
```

#### Property Value

 RepeatedField<[CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md).[Types](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.md).[MapData](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.Types.MapData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Clone"></a> Clone\(\)

```csharp
public CSource2Metrics_FetchMapData_Response Clone()
```

#### Returns

 [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_Equals_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_"></a> Equals\(CSource2Metrics\_FetchMapData\_Response\)

```csharp
public bool Equals(CSource2Metrics_FetchMapData_Response other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_MergeFrom_Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_"></a> MergeFrom\(CSource2Metrics\_FetchMapData\_Response\)

```csharp
public void MergeFrom(CSource2Metrics_FetchMapData_Response other)
```

#### Parameters

`other` [CSource2Metrics\_FetchMapData\_Response](Divine.Protobufs.Dota2.CSource2Metrics\_FetchMapData\_Response.md)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSource2Metrics_FetchMapData_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

