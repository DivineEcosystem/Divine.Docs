# <a id="Divine_Protobufs_Dota2_CMsgRedeemCode"></a> Class CMsgRedeemCode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgRedeemCode : IMessage<CMsgRedeemCode>, IEquatable<CMsgRedeemCode>, IDeepCloneable<CMsgRedeemCode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgRedeemCode](Divine.Protobufs.Dota2.CMsgRedeemCode.md)

#### Implements

IMessage<CMsgRedeemCode\>, 
[IEquatable<CMsgRedeemCode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgRedeemCode\>, 
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
[EnumerableExtensions.In<CMsgRedeemCode\>\(CMsgRedeemCode, params CMsgRedeemCode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode__ctor"></a> CMsgRedeemCode\(\)

```csharp
public CMsgRedeemCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode__ctor_Divine_Protobufs_Dota2_CMsgRedeemCode_"></a> CMsgRedeemCode\(CMsgRedeemCode\)

```csharp
public CMsgRedeemCode(CMsgRedeemCode other)
```

#### Parameters

`other` [CMsgRedeemCode](Divine.Protobufs.Dota2.CMsgRedeemCode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_CodeFieldNumber"></a> CodeFieldNumber

```csharp
public const int CodeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_Code"></a> Code

```csharp
public string Code { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_HasCode"></a> HasCode

```csharp
public bool HasCode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_Parser"></a> Parser

```csharp
public static MessageParser<CMsgRedeemCode> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgRedeemCode](Divine.Protobufs.Dota2.CMsgRedeemCode.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_ClearCode"></a> ClearCode\(\)

```csharp
public void ClearCode()
```

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_Clone"></a> Clone\(\)

```csharp
public CMsgRedeemCode Clone()
```

#### Returns

 [CMsgRedeemCode](Divine.Protobufs.Dota2.CMsgRedeemCode.md)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_Equals_Divine_Protobufs_Dota2_CMsgRedeemCode_"></a> Equals\(CMsgRedeemCode\)

```csharp
public bool Equals(CMsgRedeemCode other)
```

#### Parameters

`other` [CMsgRedeemCode](Divine.Protobufs.Dota2.CMsgRedeemCode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_MergeFrom_Divine_Protobufs_Dota2_CMsgRedeemCode_"></a> MergeFrom\(CMsgRedeemCode\)

```csharp
public void MergeFrom(CMsgRedeemCode other)
```

#### Parameters

`other` [CMsgRedeemCode](Divine.Protobufs.Dota2.CMsgRedeemCode.md)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgRedeemCode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

