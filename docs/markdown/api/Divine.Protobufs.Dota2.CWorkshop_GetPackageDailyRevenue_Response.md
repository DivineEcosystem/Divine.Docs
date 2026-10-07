# <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response"></a> Class CWorkshop\_GetPackageDailyRevenue\_Response

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_GetPackageDailyRevenue_Response : IMessage<CWorkshop_GetPackageDailyRevenue_Response>, IEquatable<CWorkshop_GetPackageDailyRevenue_Response>, IDeepCloneable<CWorkshop_GetPackageDailyRevenue_Response>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md)

#### Implements

IMessage<CWorkshop\_GetPackageDailyRevenue\_Response\>, 
[IEquatable<CWorkshop\_GetPackageDailyRevenue\_Response\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_GetPackageDailyRevenue\_Response\>, 
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
[EnumerableExtensions.In<CWorkshop\_GetPackageDailyRevenue\_Response\>\(CWorkshop\_GetPackageDailyRevenue\_Response, params CWorkshop\_GetPackageDailyRevenue\_Response\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response__ctor"></a> CWorkshop\_GetPackageDailyRevenue\_Response\(\)

```csharp
public CWorkshop_GetPackageDailyRevenue_Response()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response__ctor_Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_"></a> CWorkshop\_GetPackageDailyRevenue\_Response\(CWorkshop\_GetPackageDailyRevenue\_Response\)

```csharp
public CWorkshop_GetPackageDailyRevenue_Response(CWorkshop_GetPackageDailyRevenue_Response other)
```

#### Parameters

`other` [CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_CountryRevenueFieldNumber"></a> CountryRevenueFieldNumber

```csharp
public const int CountryRevenueFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_CountryRevenue"></a> CountryRevenue

```csharp
public RepeatedField<CWorkshop_GetPackageDailyRevenue_Response.Types.CountryDailyRevenue> CountryRevenue { get; }
```

#### Property Value

 RepeatedField<[CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.Types.md).[CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.Types.CountryDailyRevenue.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_GetPackageDailyRevenue_Response> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_Clone"></a> Clone\(\)

```csharp
public CWorkshop_GetPackageDailyRevenue_Response Clone()
```

#### Returns

 [CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_Equals_Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_"></a> Equals\(CWorkshop\_GetPackageDailyRevenue\_Response\)

```csharp
public bool Equals(CWorkshop_GetPackageDailyRevenue_Response other)
```

#### Parameters

`other` [CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_"></a> MergeFrom\(CWorkshop\_GetPackageDailyRevenue\_Response\)

```csharp
public void MergeFrom(CWorkshop_GetPackageDailyRevenue_Response other)
```

#### Parameters

`other` [CWorkshop\_GetPackageDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetPackageDailyRevenue\_Response.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetPackageDailyRevenue_Response_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

