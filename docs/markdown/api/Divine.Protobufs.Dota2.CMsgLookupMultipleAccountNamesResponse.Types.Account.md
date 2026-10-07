# <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account"></a> Class CMsgLookupMultipleAccountNamesResponse.Types.Account

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLookupMultipleAccountNamesResponse.Types.Account : IMessage<CMsgLookupMultipleAccountNamesResponse.Types.Account>, IEquatable<CMsgLookupMultipleAccountNamesResponse.Types.Account>, IDeepCloneable<CMsgLookupMultipleAccountNamesResponse.Types.Account>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLookupMultipleAccountNamesResponse.Types.Account](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.Account.md)

#### Implements

IMessage<CMsgLookupMultipleAccountNamesResponse.Types.Account\>, 
[IEquatable<CMsgLookupMultipleAccountNamesResponse.Types.Account\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLookupMultipleAccountNamesResponse.Types.Account\>, 
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
[EnumerableExtensions.In<CMsgLookupMultipleAccountNamesResponse.Types.Account\>\(CMsgLookupMultipleAccountNamesResponse.Types.Account, params CMsgLookupMultipleAccountNamesResponse.Types.Account\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account__ctor"></a> Account\(\)

```csharp
public Account()
```

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account__ctor_Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_"></a> Account\(Account\)

```csharp
public Account(CMsgLookupMultipleAccountNamesResponse.Types.Account other)
```

#### Parameters

`other` [CMsgLookupMultipleAccountNamesResponse](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.md).[Account](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.Account.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_AccountidFieldNumber"></a> AccountidFieldNumber

```csharp
public const int AccountidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_PersonaFieldNumber"></a> PersonaFieldNumber

```csharp
public const int PersonaFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Accountid"></a> Accountid

```csharp
public uint Accountid { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_HasAccountid"></a> HasAccountid

```csharp
public bool HasAccountid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_HasPersona"></a> HasPersona

```csharp
public bool HasPersona { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLookupMultipleAccountNamesResponse.Types.Account> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLookupMultipleAccountNamesResponse](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.md).[Account](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.Account.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Persona"></a> Persona

```csharp
public string Persona { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_ClearAccountid"></a> ClearAccountid\(\)

```csharp
public void ClearAccountid()
```

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_ClearPersona"></a> ClearPersona\(\)

```csharp
public void ClearPersona()
```

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Clone"></a> Clone\(\)

```csharp
public CMsgLookupMultipleAccountNamesResponse.Types.Account Clone()
```

#### Returns

 [CMsgLookupMultipleAccountNamesResponse](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.md).[Account](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.Account.md)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_Equals_Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_"></a> Equals\(Account\)

```csharp
public bool Equals(CMsgLookupMultipleAccountNamesResponse.Types.Account other)
```

#### Parameters

`other` [CMsgLookupMultipleAccountNamesResponse](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.md).[Account](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.Account.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_MergeFrom_Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_"></a> MergeFrom\(Account\)

```csharp
public void MergeFrom(CMsgLookupMultipleAccountNamesResponse.Types.Account other)
```

#### Parameters

`other` [CMsgLookupMultipleAccountNamesResponse](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.md).[Types](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.md).[Account](Divine.Protobufs.Dota2.CMsgLookupMultipleAccountNamesResponse.Types.Account.md)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLookupMultipleAccountNamesResponse_Types_Account_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

