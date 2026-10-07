# <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions"></a> Class CMsgGCMsgSetOptions

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgSetOptions : IMessage<CMsgGCMsgSetOptions>, IEquatable<CMsgGCMsgSetOptions>, IDeepCloneable<CMsgGCMsgSetOptions>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md)

#### Implements

IMessage<CMsgGCMsgSetOptions\>, 
[IEquatable<CMsgGCMsgSetOptions\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgSetOptions\>, 
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
[EnumerableExtensions.In<CMsgGCMsgSetOptions\>\(CMsgGCMsgSetOptions, params CMsgGCMsgSetOptions\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions__ctor"></a> CMsgGCMsgSetOptions\(\)

```csharp
public CMsgGCMsgSetOptions()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions__ctor_Divine_Protobufs_Steam_CMsgGCMsgSetOptions_"></a> CMsgGCMsgSetOptions\(CMsgGCMsgSetOptions\)

```csharp
public CMsgGCMsgSetOptions(CMsgGCMsgSetOptions other)
```

#### Parameters

`other` [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_ClientMsgRangesFieldNumber"></a> ClientMsgRangesFieldNumber

```csharp
public const int ClientMsgRangesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_GcsqlVersionFieldNumber"></a> GcsqlVersionFieldNumber

```csharp
public const int GcsqlVersionFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_OptionsFieldNumber"></a> OptionsFieldNumber

```csharp
public const int OptionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_ClientMsgRanges"></a> ClientMsgRanges

```csharp
public RepeatedField<CMsgGCMsgSetOptions.Types.MessageRange> ClientMsgRanges { get; }
```

#### Property Value

 RepeatedField<[CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_GcsqlVersion"></a> GcsqlVersion

```csharp
public CMsgGCMsgSetOptions.Types.GCSQLVersion GcsqlVersion { get; set; }
```

#### Property Value

 [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[GCSQLVersion](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.GCSQLVersion.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_HasGcsqlVersion"></a> HasGcsqlVersion

```csharp
public bool HasGcsqlVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Options"></a> Options

```csharp
public RepeatedField<CMsgGCMsgSetOptions.Types.Option> Options { get; }
```

#### Property Value

 RepeatedField<[CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[Option](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.Option.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgSetOptions> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_ClearGcsqlVersion"></a> ClearGcsqlVersion\(\)

```csharp
public void ClearGcsqlVersion()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgSetOptions Clone()
```

#### Returns

 [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Equals_Divine_Protobufs_Steam_CMsgGCMsgSetOptions_"></a> Equals\(CMsgGCMsgSetOptions\)

```csharp
public bool Equals(CMsgGCMsgSetOptions other)
```

#### Parameters

`other` [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgSetOptions_"></a> MergeFrom\(CMsgGCMsgSetOptions\)

```csharp
public void MergeFrom(CMsgGCMsgSetOptions other)
```

#### Parameters

`other` [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

