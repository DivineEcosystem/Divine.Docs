# <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg"></a> Class CUserMessageCreditsMsg

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageCreditsMsg : IMessage<CUserMessageCreditsMsg>, IEquatable<CUserMessageCreditsMsg>, IDeepCloneable<CUserMessageCreditsMsg>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageCreditsMsg](Divine.Protobufs.Dota2.CUserMessageCreditsMsg.md)

#### Implements

IMessage<CUserMessageCreditsMsg\>, 
[IEquatable<CUserMessageCreditsMsg\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageCreditsMsg\>, 
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
[EnumerableExtensions.In<CUserMessageCreditsMsg\>\(CUserMessageCreditsMsg, params CUserMessageCreditsMsg\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg__ctor"></a> CUserMessageCreditsMsg\(\)

```csharp
public CUserMessageCreditsMsg()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg__ctor_Divine_Protobufs_Dota2_CUserMessageCreditsMsg_"></a> CUserMessageCreditsMsg\(CUserMessageCreditsMsg\)

```csharp
public CUserMessageCreditsMsg(CUserMessageCreditsMsg other)
```

#### Parameters

`other` [CUserMessageCreditsMsg](Divine.Protobufs.Dota2.CUserMessageCreditsMsg.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_LogoLengthFieldNumber"></a> LogoLengthFieldNumber

```csharp
public const int LogoLengthFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_RolltypeFieldNumber"></a> RolltypeFieldNumber

```csharp
public const int RolltypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_HasLogoLength"></a> HasLogoLength

```csharp
public bool HasLogoLength { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_HasRolltype"></a> HasRolltype

```csharp
public bool HasRolltype { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_LogoLength"></a> LogoLength

```csharp
public float LogoLength { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageCreditsMsg> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageCreditsMsg](Divine.Protobufs.Dota2.CUserMessageCreditsMsg.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_Rolltype"></a> Rolltype

```csharp
public eRollType Rolltype { get; set; }
```

#### Property Value

 [eRollType](Divine.Protobufs.Dota2.eRollType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_ClearLogoLength"></a> ClearLogoLength\(\)

```csharp
public void ClearLogoLength()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_ClearRolltype"></a> ClearRolltype\(\)

```csharp
public void ClearRolltype()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_Clone"></a> Clone\(\)

```csharp
public CUserMessageCreditsMsg Clone()
```

#### Returns

 [CUserMessageCreditsMsg](Divine.Protobufs.Dota2.CUserMessageCreditsMsg.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_Equals_Divine_Protobufs_Dota2_CUserMessageCreditsMsg_"></a> Equals\(CUserMessageCreditsMsg\)

```csharp
public bool Equals(CUserMessageCreditsMsg other)
```

#### Parameters

`other` [CUserMessageCreditsMsg](Divine.Protobufs.Dota2.CUserMessageCreditsMsg.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_MergeFrom_Divine_Protobufs_Dota2_CUserMessageCreditsMsg_"></a> MergeFrom\(CUserMessageCreditsMsg\)

```csharp
public void MergeFrom(CUserMessageCreditsMsg other)
```

#### Parameters

`other` [CUserMessageCreditsMsg](Divine.Protobufs.Dota2.CUserMessageCreditsMsg.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageCreditsMsg_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

