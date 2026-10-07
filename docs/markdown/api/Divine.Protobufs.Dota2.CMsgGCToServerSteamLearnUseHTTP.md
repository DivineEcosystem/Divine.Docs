# <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP"></a> Class CMsgGCToServerSteamLearnUseHTTP

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToServerSteamLearnUseHTTP : IMessage<CMsgGCToServerSteamLearnUseHTTP>, IEquatable<CMsgGCToServerSteamLearnUseHTTP>, IDeepCloneable<CMsgGCToServerSteamLearnUseHTTP>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToServerSteamLearnUseHTTP](Divine.Protobufs.Dota2.CMsgGCToServerSteamLearnUseHTTP.md)

#### Implements

IMessage<CMsgGCToServerSteamLearnUseHTTP\>, 
[IEquatable<CMsgGCToServerSteamLearnUseHTTP\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToServerSteamLearnUseHTTP\>, 
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
[EnumerableExtensions.In<CMsgGCToServerSteamLearnUseHTTP\>\(CMsgGCToServerSteamLearnUseHTTP, params CMsgGCToServerSteamLearnUseHTTP\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP__ctor"></a> CMsgGCToServerSteamLearnUseHTTP\(\)

```csharp
public CMsgGCToServerSteamLearnUseHTTP()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP__ctor_Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_"></a> CMsgGCToServerSteamLearnUseHTTP\(CMsgGCToServerSteamLearnUseHTTP\)

```csharp
public CMsgGCToServerSteamLearnUseHTTP(CMsgGCToServerSteamLearnUseHTTP other)
```

#### Parameters

`other` [CMsgGCToServerSteamLearnUseHTTP](Divine.Protobufs.Dota2.CMsgGCToServerSteamLearnUseHTTP.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_UseHttpFieldNumber"></a> UseHttpFieldNumber

```csharp
public const int UseHttpFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_HasUseHttp"></a> HasUseHttp

```csharp
public bool HasUseHttp { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToServerSteamLearnUseHTTP> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToServerSteamLearnUseHTTP](Divine.Protobufs.Dota2.CMsgGCToServerSteamLearnUseHTTP.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_UseHttp"></a> UseHttp

```csharp
public bool UseHttp { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_ClearUseHttp"></a> ClearUseHttp\(\)

```csharp
public void ClearUseHttp()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_Clone"></a> Clone\(\)

```csharp
public CMsgGCToServerSteamLearnUseHTTP Clone()
```

#### Returns

 [CMsgGCToServerSteamLearnUseHTTP](Divine.Protobufs.Dota2.CMsgGCToServerSteamLearnUseHTTP.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_Equals_Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_"></a> Equals\(CMsgGCToServerSteamLearnUseHTTP\)

```csharp
public bool Equals(CMsgGCToServerSteamLearnUseHTTP other)
```

#### Parameters

`other` [CMsgGCToServerSteamLearnUseHTTP](Divine.Protobufs.Dota2.CMsgGCToServerSteamLearnUseHTTP.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_"></a> MergeFrom\(CMsgGCToServerSteamLearnUseHTTP\)

```csharp
public void MergeFrom(CMsgGCToServerSteamLearnUseHTTP other)
```

#### Parameters

`other` [CMsgGCToServerSteamLearnUseHTTP](Divine.Protobufs.Dota2.CMsgGCToServerSteamLearnUseHTTP.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToServerSteamLearnUseHTTP_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

