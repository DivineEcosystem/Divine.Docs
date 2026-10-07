# <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue"></a> Class CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue : IMessage<CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue>, IEquatable<CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue>, IDeepCloneable<CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue.md)

#### Implements

IMessage<CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue\>, 
[IEquatable<CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue\>, 
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
[EnumerableExtensions.In<CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue\>\(CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue, params CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue__ctor"></a> CountryDailyRevenue\(\)

```csharp
public CountryDailyRevenue()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue__ctor_Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_"></a> CountryDailyRevenue\(CountryDailyRevenue\)

```csharp
public CountryDailyRevenue(CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue other)
```

#### Parameters

`other` [CWorkshop\_GetItemDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.md).[CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_CountryCodeFieldNumber"></a> CountryCodeFieldNumber

```csharp
public const int CountryCodeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_DateFieldNumber"></a> DateFieldNumber

```csharp
public const int DateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_RevenueUsdFieldNumber"></a> RevenueUsdFieldNumber

```csharp
public const int RevenueUsdFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_UnitsFieldNumber"></a> UnitsFieldNumber

```csharp
public const int UnitsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_CountryCode"></a> CountryCode

```csharp
public string CountryCode { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Date"></a> Date

```csharp
public uint Date { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_HasCountryCode"></a> HasCountryCode

```csharp
public bool HasCountryCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_HasDate"></a> HasDate

```csharp
public bool HasDate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_HasRevenueUsd"></a> HasRevenueUsd

```csharp
public bool HasRevenueUsd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_HasUnits"></a> HasUnits

```csharp
public bool HasUnits { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Parser"></a> Parser

```csharp
public static MessageParser<CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue> Parser { get; }
```

#### Property Value

 MessageParser<[CWorkshop\_GetItemDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.md).[CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue.md)\>

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_RevenueUsd"></a> RevenueUsd

```csharp
public long RevenueUsd { get; set; }
```

#### Property Value

 [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Units"></a> Units

```csharp
public int Units { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_ClearCountryCode"></a> ClearCountryCode\(\)

```csharp
public void ClearCountryCode()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_ClearDate"></a> ClearDate\(\)

```csharp
public void ClearDate()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_ClearRevenueUsd"></a> ClearRevenueUsd\(\)

```csharp
public void ClearRevenueUsd()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_ClearUnits"></a> ClearUnits\(\)

```csharp
public void ClearUnits()
```

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Clone"></a> Clone\(\)

```csharp
public CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue Clone()
```

#### Returns

 [CWorkshop\_GetItemDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.md).[CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_Equals_Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_"></a> Equals\(CountryDailyRevenue\)

```csharp
public bool Equals(CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue other)
```

#### Parameters

`other` [CWorkshop\_GetItemDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.md).[CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_MergeFrom_Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_"></a> MergeFrom\(CountryDailyRevenue\)

```csharp
public void MergeFrom(CWorkshop_GetItemDailyRevenue_Response.Types.CountryDailyRevenue other)
```

#### Parameters

`other` [CWorkshop\_GetItemDailyRevenue\_Response](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.md).[Types](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.md).[CountryDailyRevenue](Divine.Protobufs.Dota2.CWorkshop\_GetItemDailyRevenue\_Response.Types.CountryDailyRevenue.md)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CWorkshop_GetItemDailyRevenue_Response_Types_CountryDailyRevenue_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

