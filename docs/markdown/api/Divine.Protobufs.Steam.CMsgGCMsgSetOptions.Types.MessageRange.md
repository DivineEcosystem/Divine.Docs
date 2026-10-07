# <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange"></a> Class CMsgGCMsgSetOptions.Types.MessageRange

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgSetOptions.Types.MessageRange : IMessage<CMsgGCMsgSetOptions.Types.MessageRange>, IEquatable<CMsgGCMsgSetOptions.Types.MessageRange>, IDeepCloneable<CMsgGCMsgSetOptions.Types.MessageRange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgSetOptions.Types.MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)

#### Implements

IMessage<CMsgGCMsgSetOptions.Types.MessageRange\>, 
[IEquatable<CMsgGCMsgSetOptions.Types.MessageRange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgSetOptions.Types.MessageRange\>, 
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
[EnumerableExtensions.In<CMsgGCMsgSetOptions.Types.MessageRange\>\(CMsgGCMsgSetOptions.Types.MessageRange, params CMsgGCMsgSetOptions.Types.MessageRange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange__ctor"></a> MessageRange\(\)

```csharp
public MessageRange()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange__ctor_Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_"></a> MessageRange\(MessageRange\)

```csharp
public MessageRange(CMsgGCMsgSetOptions.Types.MessageRange other)
```

#### Parameters

`other` [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_HighFieldNumber"></a> HighFieldNumber

```csharp
public const int HighFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_LowFieldNumber"></a> LowFieldNumber

```csharp
public const int LowFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_HasHigh"></a> HasHigh

```csharp
public bool HasHigh { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_HasLow"></a> HasLow

```csharp
public bool HasLow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_High"></a> High

```csharp
public uint High { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_Low"></a> Low

```csharp
public uint Low { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgSetOptions.Types.MessageRange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_ClearHigh"></a> ClearHigh\(\)

```csharp
public void ClearHigh()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_ClearLow"></a> ClearLow\(\)

```csharp
public void ClearLow()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgSetOptions.Types.MessageRange Clone()
```

#### Returns

 [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_Equals_Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_"></a> Equals\(MessageRange\)

```csharp
public bool Equals(CMsgGCMsgSetOptions.Types.MessageRange other)
```

#### Parameters

`other` [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_"></a> MergeFrom\(MessageRange\)

```csharp
public void MergeFrom(CMsgGCMsgSetOptions.Types.MessageRange other)
```

#### Parameters

`other` [CMsgGCMsgSetOptions](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.md).[MessageRange](Divine.Protobufs.Steam.CMsgGCMsgSetOptions.Types.MessageRange.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgSetOptions_Types_MessageRange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

