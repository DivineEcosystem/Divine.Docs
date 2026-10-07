# <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit"></a> Class CMsgGCStorePurchaseInit

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCStorePurchaseInit : IMessage<CMsgGCStorePurchaseInit>, IEquatable<CMsgGCStorePurchaseInit>, IDeepCloneable<CMsgGCStorePurchaseInit>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCStorePurchaseInit](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInit.md)

#### Implements

IMessage<CMsgGCStorePurchaseInit\>, 
[IEquatable<CMsgGCStorePurchaseInit\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCStorePurchaseInit\>, 
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
[EnumerableExtensions.In<CMsgGCStorePurchaseInit\>\(CMsgGCStorePurchaseInit, params CMsgGCStorePurchaseInit\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit__ctor"></a> CMsgGCStorePurchaseInit\(\)

```csharp
public CMsgGCStorePurchaseInit()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit__ctor_Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_"></a> CMsgGCStorePurchaseInit\(CMsgGCStorePurchaseInit\)

```csharp
public CMsgGCStorePurchaseInit(CMsgGCStorePurchaseInit other)
```

#### Parameters

`other` [CMsgGCStorePurchaseInit](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInit.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_CountryFieldNumber"></a> CountryFieldNumber

```csharp
public const int CountryFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_CurrencyFieldNumber"></a> CurrencyFieldNumber

```csharp
public const int CurrencyFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_LanguageFieldNumber"></a> LanguageFieldNumber

```csharp
public const int LanguageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_LineItemsFieldNumber"></a> LineItemsFieldNumber

```csharp
public const int LineItemsFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Country"></a> Country

```csharp
public string Country { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Currency"></a> Currency

```csharp
public int Currency { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_HasCountry"></a> HasCountry

```csharp
public bool HasCountry { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_HasCurrency"></a> HasCurrency

```csharp
public bool HasCurrency { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_HasLanguage"></a> HasLanguage

```csharp
public bool HasLanguage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Language"></a> Language

```csharp
public int Language { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_LineItems"></a> LineItems

```csharp
public RepeatedField<CGCStorePurchaseInit_LineItem> LineItems { get; }
```

#### Property Value

 RepeatedField<[CGCStorePurchaseInit\_LineItem](Divine.Protobufs.Dota2.CGCStorePurchaseInit\_LineItem.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCStorePurchaseInit> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCStorePurchaseInit](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInit.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_ClearCountry"></a> ClearCountry\(\)

```csharp
public void ClearCountry()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_ClearCurrency"></a> ClearCurrency\(\)

```csharp
public void ClearCurrency()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_ClearLanguage"></a> ClearLanguage\(\)

```csharp
public void ClearLanguage()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Clone"></a> Clone\(\)

```csharp
public CMsgGCStorePurchaseInit Clone()
```

#### Returns

 [CMsgGCStorePurchaseInit](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInit.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_Equals_Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_"></a> Equals\(CMsgGCStorePurchaseInit\)

```csharp
public bool Equals(CMsgGCStorePurchaseInit other)
```

#### Parameters

`other` [CMsgGCStorePurchaseInit](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInit.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_MergeFrom_Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_"></a> MergeFrom\(CMsgGCStorePurchaseInit\)

```csharp
public void MergeFrom(CMsgGCStorePurchaseInit other)
```

#### Parameters

`other` [CMsgGCStorePurchaseInit](Divine.Protobufs.Dota2.CMsgGCStorePurchaseInit.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCStorePurchaseInit_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

