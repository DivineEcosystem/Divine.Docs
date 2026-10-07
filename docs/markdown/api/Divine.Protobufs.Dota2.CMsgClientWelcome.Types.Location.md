# <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location"></a> Class CMsgClientWelcome.Types.Location

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientWelcome.Types.Location : IMessage<CMsgClientWelcome.Types.Location>, IEquatable<CMsgClientWelcome.Types.Location>, IDeepCloneable<CMsgClientWelcome.Types.Location>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientWelcome.Types.Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)

#### Implements

IMessage<CMsgClientWelcome.Types.Location\>, 
[IEquatable<CMsgClientWelcome.Types.Location\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientWelcome.Types.Location\>, 
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
[EnumerableExtensions.In<CMsgClientWelcome.Types.Location\>\(CMsgClientWelcome.Types.Location, params CMsgClientWelcome.Types.Location\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location__ctor"></a> Location\(\)

```csharp
public Location()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location__ctor_Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_"></a> Location\(Location\)

```csharp
public Location(CMsgClientWelcome.Types.Location other)
```

#### Parameters

`other` [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.md).[Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_CountryFieldNumber"></a> CountryFieldNumber

```csharp
public const int CountryFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_LatitudeFieldNumber"></a> LatitudeFieldNumber

```csharp
public const int LatitudeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_LongitudeFieldNumber"></a> LongitudeFieldNumber

```csharp
public const int LongitudeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Country"></a> Country

```csharp
public string Country { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_HasCountry"></a> HasCountry

```csharp
public bool HasCountry { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_HasLatitude"></a> HasLatitude

```csharp
public bool HasLatitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_HasLongitude"></a> HasLongitude

```csharp
public bool HasLongitude { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Latitude"></a> Latitude

```csharp
public float Latitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Longitude"></a> Longitude

```csharp
public float Longitude { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientWelcome.Types.Location> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.md).[Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_ClearCountry"></a> ClearCountry\(\)

```csharp
public void ClearCountry()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_ClearLatitude"></a> ClearLatitude\(\)

```csharp
public void ClearLatitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_ClearLongitude"></a> ClearLongitude\(\)

```csharp
public void ClearLongitude()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Clone"></a> Clone\(\)

```csharp
public CMsgClientWelcome.Types.Location Clone()
```

#### Returns

 [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.md).[Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_Equals_Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_"></a> Equals\(Location\)

```csharp
public bool Equals(CMsgClientWelcome.Types.Location other)
```

#### Parameters

`other` [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.md).[Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_MergeFrom_Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_"></a> MergeFrom\(Location\)

```csharp
public void MergeFrom(CMsgClientWelcome.Types.Location other)
```

#### Parameters

`other` [CMsgClientWelcome](Divine.Protobufs.Dota2.CMsgClientWelcome.md).[Types](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.md).[Location](Divine.Protobufs.Dota2.CMsgClientWelcome.Types.Location.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientWelcome_Types_Location_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

