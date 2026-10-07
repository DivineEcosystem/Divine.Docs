# <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice"></a> Class CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice : IMessage<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice>, IEquatable<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice>, IDeepCloneable<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice.md)

#### Implements

IMessage<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice\>, 
[IEquatable<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice\>, 
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
[EnumerableExtensions.In<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice\>\(CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice, params CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice__ctor"></a> TitleChoice\(\)

```csharp
public TitleChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice__ctor_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_"></a> TitleChoice\(TitleChoice\)

```csharp
public TitleChoice(CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingPerformOperationResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.md).[TitleChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_PrefixChoiceFieldNumber"></a> PrefixChoiceFieldNumber

```csharp
public const int PrefixChoiceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_SuffixChoiceFieldNumber"></a> SuffixChoiceFieldNumber

```csharp
public const int SuffixChoiceFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_HasPrefixChoice"></a> HasPrefixChoice

```csharp
public bool HasPrefixChoice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_HasSuffixChoice"></a> HasSuffixChoice

```csharp
public bool HasSuffixChoice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCFantasyCraftingPerformOperationResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.md).[TitleChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_PrefixChoice"></a> PrefixChoice

```csharp
public uint PrefixChoice { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_SuffixChoice"></a> SuffixChoice

```csharp
public uint SuffixChoice { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_ClearPrefixChoice"></a> ClearPrefixChoice\(\)

```csharp
public void ClearPrefixChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_ClearSuffixChoice"></a> ClearSuffixChoice\(\)

```csharp
public void ClearSuffixChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice Clone()
```

#### Returns

 [CMsgClientToGCFantasyCraftingPerformOperationResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.md).[TitleChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_Equals_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_"></a> Equals\(TitleChoice\)

```csharp
public bool Equals(CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingPerformOperationResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.md).[TitleChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_"></a> MergeFrom\(TitleChoice\)

```csharp
public void MergeFrom(CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice other)
```

#### Parameters

`other` [CMsgClientToGCFantasyCraftingPerformOperationResponse](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.md).[TitleChoice](Divine.Protobufs.Dota2.CMsgClientToGCFantasyCraftingPerformOperationResponse.Types.TitleChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCFantasyCraftingPerformOperationResponse_Types_TitleChoice_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

